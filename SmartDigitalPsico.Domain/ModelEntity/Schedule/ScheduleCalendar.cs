using SmartDigitalPsico.Domain.Contracts;

namespace SmartDigitalPsico.Domain.ModelEntity.Schedule
{
    /// <summary>
    /// Generic schedule package (1 row per series/lote). Intervals live in ScheduleData JSON.
    /// No Medical/Patient FKs — use TenantKey / OwnerKey / SubjectKey for multi-system reuse.
    /// </summary>
    public class ScheduleCalendar : EntityBase
    {
        public string TenantKey { get; set; } = string.Empty;
        public string OwnerKey { get; set; } = string.Empty;
        public string? SubjectKey { get; set; }
        public string UniqueToken { get; set; } = string.Empty;
        public DateTime StartPeriod { get; set; }
        public DateTime EndPeriod { get; set; }
        public ScheduleCalendarItem[] ScheduleData { get; set; } = [];
    }
}
