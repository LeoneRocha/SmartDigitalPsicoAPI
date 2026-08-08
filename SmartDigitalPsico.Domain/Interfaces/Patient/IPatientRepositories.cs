using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Medical;

namespace SmartDigitalPsico.Domain.Interfaces.Patient
{
    /// <summary>
    /// Interface (contrato) responsável por IPatientRepositories.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IPatientRepositories
    {
        IMedicalRepository MedicalRepository { get; }
        IPatientRecordRepository PatientRecordRepository { get; }
        IPatientRepository PatientRepository { get; }
        ISharedRepositories SharedRepositories { get; }
    }
}
