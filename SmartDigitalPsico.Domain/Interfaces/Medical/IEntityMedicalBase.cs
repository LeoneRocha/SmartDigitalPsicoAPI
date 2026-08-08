using SmartDigitalPsico.Domain.ModelEntity.Schedule;

using MedicalEntity = SmartDigitalPsico.Domain.ModelEntity.Medical;

using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Medical
{
    /// <summary>
    /// Interface (contrato) responsável por IEntityMedicalBase.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IEntityMedicalBase  
    {
        public MedicalEntity? Medical { get; set; }
        public long MedicalId { get; set; } 
    }  
}
