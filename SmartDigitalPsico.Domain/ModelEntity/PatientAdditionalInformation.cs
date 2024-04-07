using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class PatientAdditionalInformation : EntityBase, IEntityBaseLogUser
    { 
        #region Columns         
        public string FollowUp_Psychiatric { get; set; } = string.Empty; 
        public string FollowUp_Neurological { get; set; } = string.Empty;
        #endregion Columns 
        
        #region Relationship
        public Patient Patient { get; set; }
        public long PatientId { get; set; }
        public User? CreatedUser { get; set; }
        public long? CreatedUserId { get; set; }
        public User? ModifyUser { get; set; }
        public long? ModifyUserId { get; set; }
        #endregion Relationship
    }
}