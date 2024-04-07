using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class MedicalCalendar : EntityBase, IEntityBaseLogUser
    { 
        #region Columns 
        public string Title { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool AllDay { get; set; }
        public EStatusCalendar Status { get; set; }
        public string ColorCategory { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public bool PushedCalendar { get; set; }
        public string TimeZone { get; set; } = string.Empty;
        public long? CreatedUserId { get; set; }
        public long? ModifyUserId { get; set; }
        #endregion Columns 

        #region Relationship  
        public Medical Medical { get; set; }
        public long MedicalId { get; set; }
        public Patient? Patient { get; set; }
        public long? PatientId { get; set; }
        public User? CreatedUser { get; set; }
        public User? ModifyUser { get; set; }
        #endregion Relationship
    }
}