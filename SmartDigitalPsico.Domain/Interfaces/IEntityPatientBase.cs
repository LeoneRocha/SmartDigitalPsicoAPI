using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces
{
    /// <summary>
    /// Interface (contrato) responsável por IEntityPatientBase.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IEntityPatientBase  
    {
        Patient? Patient { get; set; }
        long PatientId { get; set; }  
    }  
}
