using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.Interfaces.Collection
{
    public interface IPatientRepositories
    {
        IMedicalRepository MedicalRepository { get; }
        IPatientRecordRepository PatientRecordRepository { get; }
        IPatientRepository PatientRepository { get; }
        IUserRepository UserRepository { get; }
    }
}