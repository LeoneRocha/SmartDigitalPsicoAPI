using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces
{
    public interface IEntityMedicalBase  
    {
        public Medical? Medical { get; set; }
        public long MedicalId { get; set; } 
    }  
}