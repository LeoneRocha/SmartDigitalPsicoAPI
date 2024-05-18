using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.ModelEntity.Contracts;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class PatientFile : FileBase, IEntityBaseLogUser
    { 
        #region Relationship 
        public Patient? Patient { get; set; }  
        public long PatientId { get; set; }
        public User? CreatedUser { get; set; }
        public User? ModifyUser { get; set; }
        public long? CreatedUserId { get; set; }         
        public long? ModifyUserId { get; set; }
        #endregion Relationship 
    }
}