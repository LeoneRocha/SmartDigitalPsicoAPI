using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class InfoTag : EntityBase, IEntityBaseLogUser
    {
        public string Tag { get; set; } = string.Empty;
        public Medical Medical { get; set; }        
        public long MedicalId { get; set; }
        public User? CreatedUser { get; set; }
        public User? ModifyUser { get; set; }         
        public long? CreatedUserId { get; set; }                
        public long? ModifyUserId { get; set; }                 
        public List<PatientInfoTag> PatientInfoTags { get; set; }          
    }
}