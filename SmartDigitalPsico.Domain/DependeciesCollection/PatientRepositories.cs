using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.DependeciesCollection
{
    public class PatientRepositories : IPatientRepositories
    {
        public IUserRepository UserRepository { get; }
        public IMedicalRepository MedicalRepository { get; }
        public IPatientRepository PatientRepository { get; }
        public IPatientRecordRepository PatientRecordRepository { get; }

        public PatientRepositories(
            IUserRepository userRepository,
            IMedicalRepository medicalRepository,
            IPatientRepository patientRepository,
            IPatientRecordRepository patientRecordRepository)
        {
            UserRepository = userRepository;
            MedicalRepository = medicalRepository;
            PatientRepository = patientRepository;
            PatientRecordRepository = patientRecordRepository;
        }
    }
}
