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
        /// Método BuildGradeAsync: mapeia ou transforma dados entre modelos.
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
                var items = request.PreloadedItems
                    ?? await _repository.GetItemsForOwnerAsync(tenant, request.OwnerKey, request.StartDate, request.EndDate);

                var days = GenerateDays(request, items, interval);
                days = ApplyFilters(request, days);
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

        private static ScheduleDayDto[] GenerateDays(
            ScheduleGradeRequest request,
            ScheduleCalendarItem[] items,
            TimeSpan interval)
        {
            var days = new List<ScheduleDayDto>();
            var nowLocal = DateHelper.GetDateTimeNowWithTimeZone(request.TimeZone);
            var dateActual = nowLocal.Date;
            var busy = items
                .Where(a => a.EndDateTime.HasValue)
                .Select(a => (a.StartDateTime, a.EndDateTime!.Value, Item: a))
                .ToList();

            for (var date = request.StartDate.Date; date <= request.EndDate.Date; date = date.AddDays(1))
            {
                var generated = TimeSlotGenerator.Generate(
                    new TimeSlotWindow
                    {
                        Date = date,
                        StartWorkingTime = request.Constraints.StartWorkingTime,
                        EndWorkingTime = request.Constraints.EndWorkingTime,
                        Interval = interval
                    },
                    busy.Select(b => (b.StartDateTime, b.Item.EndDateTime!.Value)).ToList(),
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

                days.Add(new ScheduleDayDto
                {
                    Date = date,
                    IsPast = date < dateActual,
                    TimeSlots = slots
                });
            }

            return days.ToArray();
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
