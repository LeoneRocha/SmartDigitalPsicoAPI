namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{
    public class ScheduleDto
    {
        public long MedicalId { get; set; }
        public string MedicalName { get; set; } = string.Empty;
        public DayScheduleDto[] Days { get; set; } = [];
    }
}
