using System.Collections.Concurrent;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using SmartDigitalPsico.Domain.DTO.Schedule.Common;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Core.SDK.Domain.VO;

using SmartDigitalPsico.Domain.Interfaces.Schedule;
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
        private readonly IAppLogger _logger;

        private static readonly ConcurrentBag<(DateTime StartDateTime, DateTime EndDateTime, ScheduleCalendarItem Item)> EmptyBusyBag = [];

        /// <summary>
        /// Método ScheduleAvailabilityService: operação de agendamento.
        /// </summary>
        public ScheduleAvailabilityService(IScheduleCalendarRepository repository, IAppLogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        /// <summary>
        /// Monta a grade: DB (ou PreloadedItems) sequencial → CPU paralelo em GenerateDays → filtros sequenciais.
        /// Persistência/leitura ocorre apenas nesta etapa inicial — GenerateDays/ApplyFilters não acessam DB.
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
        /// Onde Parallel: (1) BuildBusyByDay com Parallel.For + ConcurrentDictionary quando N busy &gt;= limiar;
        /// (2) Parallel.For por dia gerando slots/match (array result[i]).
        /// Ganho esperado: grade mensal densa — índice thread-safe + dias em paralelo.
        /// Por que slots sequenciais no dia: TimeSlotGenerator(allowParallel:false) evita Parallel aninhado.
        /// Por que dias usam array e não ConcurrentDictionary: ordem por índice sem sort.
        /// </summary>
        private static ScheduleDayDto[] GenerateDays(
            ScheduleGradeRequest request,
            ScheduleCalendarItem[] items,
            TimeSpan interval)
        {
            var nowLocal = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowWithTimeZone(request.TimeZone);
            var dateActual = nowLocal.Date;

            var busy = items
                .Where(a => a.EndDateTime.HasValue)
                .Select(a => (StartDateTime: a.StartDateTime, EndDateTime: a.EndDateTime!.Value, Item: a))
                .ToArray();

            var start = request.StartDate.Date;
            var end = request.EndDate.Date;
            var dayCount = (int)(end - start).TotalDays + 1;
            if (dayCount <= 0)
                return [];

            var busyByDay = BuildBusyByDay(busy, start, end);

            var result = new ScheduleDayDto[dayCount];
            var startWorking = request.Constraints.StartWorkingTime;
            var endWorking = request.Constraints.EndWorkingTime;

            Parallel.For(0, dayCount, ScheduleParallel.MaxAvailableThreads, i =>
            {
                var date = start.AddDays(i);
                var dayBusy = busyByDay.TryGetValue(date, out var bag) ? bag : EmptyBusyBag;

                var busyRanges = dayBusy
                    .Select(b => (b.StartDateTime, b.EndDateTime))
                    .ToList();

                // allowParallel:false — Parallel já está no nível do dia.
                var generated = TimeSlotGenerator.Generate(
                    new TimeSlotWindow
                    {
                        Date = date,
                        StartWorkingTime = startWorking,
                        EndWorkingTime = endWorking,
                        Interval = interval
                    },
                    busyRanges,
                    nowLocal,
                    allowParallel: false);

                var slots = generated
                    .Select(slot =>
                    {
                        var matched = dayBusy
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

        /// <summary>
        /// Onde Parallel: Parallel.For sobre busy quando Length &gt;= MapParallelThreshold.
        /// ConcurrentDictionary&lt;DateTime, ConcurrentBag&gt;: várias threads podem inserir no mesmo dia com segurança.
        /// Ganho esperado: muitos bookings no período (calendários densos).
        /// Abaixo do limiar: mesmo ConcurrentDictionary, preenchimento sequencial (overhead de Parallel não compensa).
        /// </summary>
        private static ConcurrentDictionary<DateTime, ConcurrentBag<(DateTime StartDateTime, DateTime EndDateTime, ScheduleCalendarItem Item)>> BuildBusyByDay(
            (DateTime StartDateTime, DateTime EndDateTime, ScheduleCalendarItem Item)[] busy,
            DateTime rangeStart,
            DateTime rangeEnd)
        {
            var dict = new ConcurrentDictionary<DateTime, ConcurrentBag<(DateTime StartDateTime, DateTime EndDateTime, ScheduleCalendarItem Item)>>();

            void AddBusy(int i)
            {
                var b = busy[i];
                var first = b.StartDateTime.Date;
                var last = b.EndDateTime.Date;
                for (var d = first; d <= last; d = d.AddDays(1))
                {
                    if (d < rangeStart || d > rangeEnd)
                        continue;
                    var bag = dict.GetOrAdd(d, static _ => []);
                    bag.Add(b);
                }
            }

            if (busy.Length >= ScheduleParallel.MapParallelThreshold)
            {
                Parallel.For(0, busy.Length, ScheduleParallel.MaxAvailableThreads, AddBusy);
            }
            else
            {
                for (var i = 0; i < busy.Length; i++)
                    AddBusy(i);
            }

            return dict;
        }

        /// <summary>
        /// Filtros LINQ sequenciais. Sem Parallel: N típico &lt;= 31 dias; projeção barata; overhead não compensa.
        /// </summary>
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
                var dateCurrent = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
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
