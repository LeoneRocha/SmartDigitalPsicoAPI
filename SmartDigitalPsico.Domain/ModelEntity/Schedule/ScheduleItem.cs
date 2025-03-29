using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.ModelEntity.Schedule
{
    // Classe auxiliar para representar cada item do calendário no JSON
    public class ScheduleItem
    {
        public string TokenRecurrence { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public bool IsAllDay { get; set; }
        public byte Status { get; set; } // EStatusCalendar como byte
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
        public required long MedicalId { get; set; }
        public required int PatientId { get; set; } 
    }
}
