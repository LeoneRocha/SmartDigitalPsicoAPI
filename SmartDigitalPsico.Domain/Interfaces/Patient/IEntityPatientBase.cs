using SmartDigitalPsico.Domain.EntityModels.Schedule;

using PatientEntity = SmartDigitalPsico.Domain.EntityModels.Patient;

using SmartDigitalPsico.Domain.EntityModels;

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
