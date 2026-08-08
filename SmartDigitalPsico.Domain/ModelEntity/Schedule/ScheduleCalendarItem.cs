using Newtonsoft.Json;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Domain.ModelEntity.Schedule
{
    /// <summary>
    /// Interval entry stored only inside ScheduleCalendar.ScheduleData JSON (not an EF entity).
    /// PackageId / OwnerKey / SubjectKey are stamped on read expansion and ignored on persist.
    /// </summary>
    public class ScheduleCalendarItem
    {
        public string Title { get; set; } = string.Empty;
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public bool IsAllDay { get; set; }
        public EStatusCalendar Status { get; set; }
        public string ColorCategoryHexa { get; set; } = string.Empty;
        public bool IsPushedCalendar { get; set; }
        public string TimeZone { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DayOfWeek[] RecurrenceDays { get; set; } = [];
        public ERecurrenceCalendarType RecurrenceType { get; set; }
        public DateTime? RecurrenceEndDate { get; set; }
        public short? RecurrenceCount { get; set; }
        public string ReasonCancellation { get; set; } = string.Empty;
        public string TokenRecurrence { get; set; } = string.Empty;

        [JsonIgnore]
        public long? PackageId { get; set; }

        [JsonIgnore]
        public string? OwnerKey { get; set; }

        [JsonIgnore]
        public string? SubjectKey { get; set; }
    }
}
