using FluentValidation;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

namespace SmartDigitalPsico.Domain.Validation.Schedule
{
    /// <summary>
    /// Generic conflict check against ScheduleCalendar SoT (owner/tenant keys).
    /// </summary>
    public class ScheduleCalendarConflictValidator : AbstractValidator<ScheduleCalendarConflictRequest>
    {
        private readonly IScheduleCalendarRepository _scheduleCalendarRepository;

        public ScheduleCalendarConflictValidator(IScheduleCalendarRepository scheduleCalendarRepository)
        {
            _scheduleCalendarRepository = scheduleCalendarRepository;

            RuleFor(x => x)
                .MustAsync(NoConflict)
                .WithErrorCode("SmartDigitalPsico.ScheduleCalendarConflictValidator.ScheduleCalendarConflictRequest.Entity.Must")
                .WithMessage("ErrorValidator_Date_Conflict|There is a date and time conflict for the same owner.");
        }

        private async Task<bool> NoConflict(ScheduleCalendarConflictRequest request, CancellationToken cancellationToken)
            => await HasNoConflictAsync(request, _scheduleCalendarRepository);

        public static async Task<bool> HasNoConflictAsync(
            ScheduleCalendarConflictRequest request,
            IScheduleCalendarRepository scheduleCalendarRepository)
        {
            var end = request.EndDateTime ?? request.StartDateTime;
            var tenant = ScheduleKeyHelper.RequireTenant(request.TenantKey);
            var items = await scheduleCalendarRepository.GetConflictingItemsAsync(
                tenant,
                request.OwnerKey,
                request.StartDateTime,
                end);

            var hasConflict = items.Any(c =>
                c.Status is not (EStatusCalendar.Canceled or EStatusCalendar.Refused)
                && ScheduleOverlapHelper.Overlaps(c.StartDateTime, c.EndDateTime, request.StartDateTime, end)
                && (string.IsNullOrWhiteSpace(request.ExcludeToken)
                    || !string.Equals(c.TokenRecurrence, request.ExcludeToken, StringComparison.Ordinal)));

            return !hasConflict;
        }
    }

    public class ScheduleCalendarConflictRequest
    {
        public string TenantKey { get; set; } = string.Empty;
        public string OwnerKey { get; set; } = string.Empty;
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string? ExcludeToken { get; set; }
    }
}
