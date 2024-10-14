using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class MedicalCalendar : EntityBase, IEntityBaseLogUser, IEntityMedicalBase
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
          
        public long? CreatedUserId { get; set; }
        public long? ModifyUserId { get; set; }

        public string Location { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DayOfWeek[] RecurrenceDays { get; set; } = []; // 0 = Sunday  1 = Monday  6 = Saturday
        public ERecurrenceCalendarType RecurrenceType { get; set; }
        public DateTime? RecurrenceEndDate { get; set; }
        public byte? RecurrenceCount { get; set; }

        #endregion Columns 

        #region Relationship  
        public Medical? Medical { get; set; }
        public long MedicalId { get; set; }
        public Patient? Patient { get; set; }
        public long? PatientId { get; set; }
        public User? CreatedUser { get; set; }
        public User? ModifyUser { get; set; }
        #endregion Relationship
    }
}