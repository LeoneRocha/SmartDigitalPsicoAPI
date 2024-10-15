using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;

namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{ 
    public class TimeSlotDto
    {
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsAvailable { get; set; } 
        public GetMedicalCalendarTimeSlotDto? MedicalCalendar { get; set; }
        public bool IsPast { get; set; }
    }
}
