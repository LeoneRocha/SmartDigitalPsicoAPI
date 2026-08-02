using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

namespace SmartDigitalPsico.Domain.DTO.Schedule
{
    public sealed class ScheduleBookRequest
    {
        public string TenantKey { get; init; } = string.Empty;
        public string OwnerKey { get; init; } = string.Empty;
        public string? SubjectKey { get; init; }
        public string UniqueToken { get; init; } = string.Empty;
        public ScheduleCalendarItem Item { get; init; } = new();
    }

    public sealed class ScheduleCancelRequest
    {
        public string TenantKey { get; init; } = string.Empty;
        public string OwnerKey { get; init; } = string.Empty;
        public string? SubjectKey { get; init; }
        public DateTime AppointmentDateTime { get; init; }
        public string? Reason { get; init; }
    }

    public sealed class ScheduleDeleteTokenRequest
    {
        public string UniqueToken { get; init; } = string.Empty;
        public string OwnerKey { get; init; } = string.Empty;
        public string? SubjectKey { get; init; }
    }

    public sealed class ScheduleCancelResult
    {
        public long PackageId { get; init; }
        public string UniqueToken { get; init; } = string.Empty;
        public EStatusCalendar NewStatus { get; init; }
    }
}
