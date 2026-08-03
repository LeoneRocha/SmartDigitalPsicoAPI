using SmartDigitalPsico.Domain.DTO.Contracts;
using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar
{
    /// <summary>
    /// Classe responsável por ActionMedicalCalendarDtoBase.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public abstract class ActionMedicalCalendarDtoBase : GetMedicalCalendarDtoBase
    {
        #region Relationship 
        public long MedicalId { get; set; }
        public long? PatientId { get; set; }
        #endregion Relationship 

        #region Columns  
        public long? CreatedUserId { get; set; }
        public long? ModifyUserId { get; set; } 
        #endregion Columns  
    }

    /// <summary>
    /// Classe responsável por GetMedicalCalendarDtoBase.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public abstract class GetMedicalCalendarDtoBase : EntityDtoBase
    { 
        #region Columns  
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
        public short RecurrenceCount { get; set; }
        public bool UpdateSeries { get; set; }
        public string TokenRecurrence { get; set; } = string.Empty;
        #endregion Columns  
    }
}
