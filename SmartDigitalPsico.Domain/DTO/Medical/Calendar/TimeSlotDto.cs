using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;

namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{ 
    public class TimeSlotDto
    {
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsAvailable { get; set; }
        public string PatientName { get; set; } = string.Empty;
        public GetMedicalCalendarDto? MedicalCalendar { get; set; }
        public bool IsPast { get; set; }
    }
}
