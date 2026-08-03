using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces
{
    /// <summary>
    /// Interface (contrato) responsável por IEntityMedicalBase.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IEntityMedicalBase  
    {
        public Medical? Medical { get; set; }
        public long MedicalId { get; set; } 
    }  
}
