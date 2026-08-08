using SmartDigitalPsico.Domain.ModelEntity;

using PatientEntity = SmartDigitalPsico.Domain.ModelEntity.Patient;

namespace SmartDigitalPsico.Domain.Interfaces.Patient
{
    /// <summary>
    /// Interface (contrato) responsável por IEntityPatientBase.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IEntityPatientBase  
    {
        PatientEntity? Patient { get; set; }
        long PatientId { get; set; }  
    }  
}
