using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.ModelEntity.Schedule
{
    /// <summary>
    /// Interval entry stored only inside ScheduleCalendar.ScheduleData JSON (not an EF entity).
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
    }
}
