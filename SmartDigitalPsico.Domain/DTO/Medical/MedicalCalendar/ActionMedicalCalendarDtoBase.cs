using SmartDigitalPsico.Domain.DTO.Contracts;
using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar
{
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
        public byte RecurrenceCount { get; set; }

        #endregion Columns  
    }
}
