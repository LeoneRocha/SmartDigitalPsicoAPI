using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class PatientNotificationMessage : EntityBase, IEntityBaseLogUser
    { 
        #region Columns  
        public string MessagePatient { get; set; } = string.Empty;         
        public bool IsReaded { get; set; } 
        public DateTime? ReadingDate { get; set; } 
        public bool Notified { get; set; } 
        public DateTime? NotifiedDate { get; set; }
        #endregion Columns 

        #region Relationship  
        public Patient Patient { get; set; } 
        public long PatientId { get; set; } 
        public User? CreatedUser { get; set; }
        public User? ModifyUser { get; set; } 
        public long? CreatedUserId { get; set; } 
        public long? ModifyUserId { get; set; }
        #endregion Relationship
    }
}