using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.ModelEntity.Contracts;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class MedicalFile : FileBase, IEntityBaseLogUser, IEntityMedicalBase
    { 
        #region Relationship         
        public Medical? Medical { get; set; }         
        public long MedicalId { get; set; }
        public User? CreatedUser { get; set; }
        public User? ModifyUser { get; set; }                
        public long? CreatedUserId { get; set; }         
        public long? ModifyUserId { get; set; }
        #endregion Relationship
    }
}