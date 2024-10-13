using SmartDigitalPsico.Domain.DTO.Contracts;
using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar
{
    public class UpdateMedicalCalendarDto : UpdateMedicalCalendarDtoBase
    {
    }
    public abstract class UpdateMedicalCalendarDtoBase : EntityDtoBase
    {
        #region Relationship 
        public long MedicalId { get; set; }
        public long? PatientId { get; set; }
        #endregion Relationship 

        #region Columns  
        public string Title { get; set; } = string.Empty;
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public bool IsAllDay { get; set; }
        public EStatusCalendar Status { get; set; }
        public string ColorCategoryHexa { get; set; } = string.Empty;

        public bool IsPushedCalendar { get; set; }
        public string TimeZone { get; set; } = string.Empty;
        public long? CreatedUserId { get; set; }
        public long? ModifyUserId { get; set; }

        public string Location { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DayOfWeek[] RecurrenceDays { get; set; } = []; 
        public ERecurrenceCalendarType RecurrenceType { get; set; }
        public DateTime? RecurrenceEndDate { get; set; }
        public int? RecurrenceCount { get; set; }

        #endregion Columns  
    }


}