using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;

namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{
    public abstract class CalendarCriteriaBaseDto
    {
        public TimeSpan Interval { get; set; }
        public GetMedicalCalendarTimeSlotDto[] MedicalCalendars { get; set; } = [];
        public TimeSpan StartWorkingTime { get; set; } // Horário que o médico começa a trabalhar
        public TimeSpan EndWorkingTime { get; set; } // Horário que o médico para de trabalhar
    }
    public class TimeSlotCriteriaDto : CalendarCriteriaBaseDto
    {
        public DateTime Date { get; set; }
    }

    public class DaysCalendarCriteriaDto : CalendarCriteriaBaseDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
