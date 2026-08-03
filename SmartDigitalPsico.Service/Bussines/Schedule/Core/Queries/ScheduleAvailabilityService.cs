using Serilog;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Core.Queries
{
    /// <summary>
    /// Classe responsável por ScheduleAvailabilityService.
    /// Responsabilidade: módulo de agendamento (Schedule).
    /// Relação: orquestra Core Schedule e contratos Medical do Domain.
    /// </summary>
    public class ScheduleAvailabilityService : IScheduleAvailabilityService
    {
        private readonly IScheduleCalendarRepository _repository;
        private readonly ILogger _logger;

        /// <summary>
        /// Método ScheduleAvailabilityService: operação de agendamento.
        /// </summary>
        public ScheduleAvailabilityService(IScheduleCalendarRepository repository, ILogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        /// <summary>
        /// Monta a grade: carrega itens do banco (ou usa PreloadedItems) e depois processa CPU em paralelo.
        /// Persistência ocorre apenas nesta etapa inicial — GenerateDays/ApplyFilters não acessam DB.
        /// </summary>
        public async Task<ServiceResponse<ScheduleGradeResult>> BuildGradeAsync(ScheduleGradeRequest request)
        {
            var response = new ServiceResponse<ScheduleGradeResult>();
            try
            {
                if (string.IsNullOrWhiteSpace(request.OwnerKey) || request.Constraints == null)
                {
                    response.Success = false;
                    response.Message = "OwnerKey and Constraints are required.";
                    return response;
                }

                var tenant = ScheduleKeyHelper.RequireTenant(request.TenantKey);
                var interval = TimeSpan.FromMinutes(Math.Max(1, request.Constraints.IntervalMinutes));

                // DB antes do paralelismo
                var items = request.PreloadedItems
                    ?? await _repository.GetItemsForOwnerAsync(tenant, request.OwnerKey, request.StartDate, request.EndDate);

                var days = GenerateDays(request, items, interval);
                days = ApplyFilters(request, days);
                // Sequencial: N pequeno e mutação in-place dos slots; paralelismo traria overhead sem ganho.
                FillMarkNonWorkingDays(days, request.Constraints.WorkingDays ?? []);
                days = days.OrderBy(d => d.Date).ToArray();

                response.Data = new ScheduleGradeResult
                {
                    OwnerKey = request.OwnerKey,
                    DisplayName = request.DisplayName
                        ?? request.Constraints.DisplayName
                        ?? string.Empty,
                    Days = days
                };
                response.Success = true;
                return response;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "ScheduleAvailabilityService.BuildGradeAsync failed");
                response.Success = false;
                response.Message = ex.Message;
                return response;
            }
        }

        /// <summary>
        /// Gera a grade diária em paralelo (CPU). Itens busy já carregados do banco antes desta etapa.
        /// Parallel.For com ScheduleParallel.MaxAvailableThreads (ProcessorCount).
        /// Slots do dia: paralelizados em TimeSlotGenerator quando N &gt;= 32.
        /// </summary>
        private static ScheduleDayDto[] GenerateDays(
            ScheduleGradeRequest request,
            ScheduleCalendarItem[] items,
            TimeSpan interval)
        {
            var nowLocal = DateHelper.GetDateTimeNowWithTimeZone(request.TimeZone);
            var dateActual = nowLocal.Date;

            // Pré-computado uma vez — evita realloc por dia (antes: busy.Select(...).ToList() a cada iteração).
            var busy = items
                .Where(a => a.EndDateTime.HasValue)
                .Select(a => (StartDateTime: a.StartDateTime, EndDateTime: a.EndDateTime!.Value, Item: a))
                .ToArray();
            var busyRanges = busy
                .Select(b => (b.StartDateTime, b.EndDateTime))
                .ToList();

            var start = request.StartDate.Date;
            var end = request.EndDate.Date;
            var dayCount = (int)(end - start).TotalDays + 1;
            if (dayCount <= 0)
                return [];

            var result = new ScheduleDayDto[dayCount];
            var startWorking = request.Constraints.StartWorkingTime;
            var endWorking = request.Constraints.EndWorkingTime;

            Parallel.For(0, dayCount, ScheduleParallel.MaxAvailableThreads, i =>
            {
                var date = start.AddDays(i);
                var generated = TimeSlotGenerator.Generate(
                    new TimeSlotWindow
                    {
                        Date = date,
                        StartWorkingTime = startWorking,
                        EndWorkingTime = endWorking,
                        Interval = interval
                    },
                    busyRanges,
                    nowLocal);

                var slots = generated
                    .Select(slot =>
                    {
                        var matched = busy
                            .Where(b => ScheduleOverlapHelper.Overlaps(b.StartDateTime, b.Item.EndDateTime, slot.StartTime, slot.EndTime))
                            .Select(b => b.Item)
                            .FirstOrDefault();

                        return new ScheduleTimeSlotDto
                        {
                            StartTime = slot.StartTime,
                            EndTime = slot.EndTime,
                            IsAvailable = matched == null && slot.IsAvailable,
                            IsPast = slot.IsPast,
                            Booking = matched
                        };
                    })
                    .OrderBy(s => s.StartTime)
                    .ToArray();

                result[i] = new ScheduleDayDto
                {
                    Date = date,
                    IsPast = date < dateActual,
                    TimeSlots = slots
                };
            });

            return result;
        }

        private static ScheduleDayDto[] ApplyFilters(ScheduleGradeRequest request, ScheduleDayDto[] days)
        {
            var result = days;

            if (request.FilterDaysWithBookingsOnly)
            {
                result = result
                    .Select(day => new ScheduleDayDto
                    {
                        Date = day.Date,
                        IsPast = day.IsPast,
                        TimeSlots = day.TimeSlots.Where(s => s.Booking != null).ToArray()
                    })
                    .Where(day => day.TimeSlots.Length > 0)
                    .ToArray();
            }

            if (request.FilterByDate.HasValue)
            {
                result = result.Where(day => day.Date.Date == request.FilterByDate.Value.Date).ToArray();
            }

            if (request.FilterByWorkingDays)
            {
                var working = request.Constraints.WorkingDays ?? [];
                result = result.Where(day => working.Contains(day.Date.DayOfWeek)).ToArray();
            }

            if (request.Mode == ScheduleGradeMode.AvailableOnly)
            {
                var dateCurrent = DateHelper.GetDateTimeNowFromUtc();
                result = result
                    .Select(day => new ScheduleDayDto
                    {
                        Date = day.Date,
                        IsPast = day.IsPast,
                        TimeSlots = day.TimeSlots
                            .Where(slot =>
                                !slot.IsPast
                                && slot.IsAvailable
                                && slot.Booking == null
                                && slot.StartTime >= dateCurrent
                                && slot.StartTime >= request.StartDate
                                && (slot.EndTime ?? slot.StartTime) <= request.EndDate)
                            .ToArray()
                    })
                    .Where(day => day.TimeSlots.Length > 0)
                    .ToArray();
            }

            return result;
        }

        /// <summary>
        /// Marca dias não úteis como indisponíveis de forma sequencial.
        /// Sem Parallel: N típico &lt;= 31 e mutação in-place; overhead de sync supera o ganho.
        /// </summary>
        private static void FillMarkNonWorkingDays(ScheduleDayDto[] days, IEnumerable<DayOfWeek> workingDays)
        {
            var working = workingDays as DayOfWeek[] ?? workingDays.ToArray();
            foreach (var day in days)
            {
                if (working.Contains(day.Date.DayOfWeek))
                    continue;

                foreach (var timeSlot in day.TimeSlots)
                    timeSlot.IsAvailable = false;
            }
        }
    }
}
