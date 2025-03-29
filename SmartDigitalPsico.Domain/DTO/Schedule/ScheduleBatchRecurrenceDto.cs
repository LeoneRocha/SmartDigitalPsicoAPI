using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.DTO.Schedule
{
    public class ScheduleBatchRecurrenceDto
    {
        public long MedicalId { get; set; }
        public long? PatientId { get; set; }
        public AddScheduleItemDto TemplateItem { get; set; } = new AddScheduleItemDto();
        public ERecurrenceCalendarType RecurrenceType { get; set; }
        public DateTime? RecurrenceEndDate { get; set; }
        public short? RecurrenceCount { get; set; }
        public DayOfWeek[] RecurrenceDays { get; set; } = Array.Empty<DayOfWeek>();
    }
}
