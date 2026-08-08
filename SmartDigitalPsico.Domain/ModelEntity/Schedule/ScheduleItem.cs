using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Domain.ModelEntity.Schedule
{
    // Classe auxiliar para representar cada item do calendário no JSON
    /// <summary>
    /// Classe responsável por ScheduleItem.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class ScheduleItem
    {
        public string TokenRecurrence { get; set; } = string.Empty;
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
        public DayOfWeek[] RecurrenceDays { get; set; } = []; 
        public ERecurrenceCalendarType RecurrenceType { get; set; }  
        public DateTime? RecurrenceEndDate { get; set; }
        public short? RecurrenceCount { get; set; }
        public string ReasonCancellation { get; set; } = string.Empty;
        public required long MedicalId { get; set; }
        public required long PatientId { get; set; } 
    }
}
