using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{
    public class AppointmentDto
    {
        public string MedicalName { get; set; } = string.Empty;
        public long MedicalId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public EStatusCalendar Status { get; set; }
        public string TimeZone { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}