using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;

namespace SmartDigitalPsico.Domain.DTO.Medical.Calendar
{
    /// <summary>
    /// Classe responsável por CalendarCriteriaBaseDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public abstract class CalendarCriteriaBaseDto
    {
        public TimeSpan Interval { get; set; }
        public GetMedicalCalendarTimeSlotDto[] MedicalCalendars { get; set; } = [];
        public TimeSpan StartWorkingTime { get; set; } // Horário que o médico começa a trabalhar
        public TimeSpan EndWorkingTime { get; set; } // Horário que o médico para de trabalhar
    }
    /// <summary>
    /// Classe responsável por TimeSlotCriteriaDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class TimeSlotCriteriaDto : CalendarCriteriaBaseDto
    {
        public DateTime Date { get; set; }
    }

    /// <summary>
    /// Classe responsável por DaysCalendarCriteriaDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class DaysCalendarCriteriaDto : CalendarCriteriaBaseDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DayOfWeek[] WorkingDays { get; set; } = [];
        public string TimeZone { get; set; } = string.Empty;
    }
}
