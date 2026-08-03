using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.Interfaces.Collection
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
