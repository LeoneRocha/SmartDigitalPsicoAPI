using SmartDigitalPsico.Domain.EntityModels.Schedule;

namespace SmartDigitalPsico.Domain.DTO.Schedule.Common
{
    /// <summary>
    /// Generic write request for ScheduleCalendar (no Medical/Patient IDs).
    /// </summary>
    public class ScheduleCalendarWriteRequest
    {
        public long? PackageId { get; set; }
        public string TenantKey { get; set; } = string.Empty;
        public string OwnerKey { get; set; } = string.Empty;
        public string? SubjectKey { get; set; }
        public string UniqueToken { get; set; } = string.Empty;
        public bool IsUpdate { get; set; }
        public bool UpdateSeries { get; set; } = true;
        public bool Enable { get; set; } = true;
        public ScheduleCalendarItem[] Items { get; set; } = [];
    }
}
