using SmartDigitalPsico.Domain.EntityModels.Schedule;

using MedicalEntity = SmartDigitalPsico.Domain.EntityModels.Medical;

using SmartDigitalPsico.Domain.EntityModels;

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
