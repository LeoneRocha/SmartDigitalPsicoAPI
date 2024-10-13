using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;

namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{
    public abstract class ScheduleCriteriaBaseDto
    {
        public TimeSpan Interval { get; set; }
        public GetMedicalCalendarDto[] MedicalCalendars { get; set; } = [];
        public TimeSpan StartWorkingTime { get; set; } // Horário que o médico começa a trabalhar
        public TimeSpan EndWorkingTime { get; set; } // Horário que o médico para de trabalhar
    }
    public class TimeSlotCriteriaDto : ScheduleCriteriaBaseDto
    {
        public DateTime Date { get; set; }
    }

    public class DaysScheduleCriteriaDto : ScheduleCriteriaBaseDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
