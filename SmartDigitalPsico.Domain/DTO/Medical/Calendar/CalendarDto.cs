namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{
    public class CalendarDto
    {
        public long MedicalId { get; set; }
        public string MedicalName { get; set; } = string.Empty;
        public DayCalendarDto[] Days { get; set; } = [];
    }
}
