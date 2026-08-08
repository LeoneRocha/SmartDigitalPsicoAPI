using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Domain.DTO.Schedule
{
    /// <summary>
    /// Classe responsável por ScheduleItemBaseDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class ScheduleItemBaseDto
    {
        public string Title { get; set; } = string.Empty;
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public bool IsAllDay { get; set; }
        public EStatusCalendar Status { get; set; }
        public string ColorCategoryHexa { get; set; } = string.Empty;
        public bool IsPushedCalendar { get; set; }
        public string TimeZone { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DayOfWeek[] RecurrenceDays { get; set; } = Array.Empty<DayOfWeek>();
        public ERecurrenceCalendarType RecurrenceType { get; set; }
        public DateTime? RecurrenceEndDate { get; set; }
        public short? RecurrenceCount { get; set; }
        public string ReasonCancellation { get; set; } = string.Empty;
    }
}
