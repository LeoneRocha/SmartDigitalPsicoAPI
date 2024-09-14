using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Domain.DependeciesCollection
{
    public class PatientRepositories : IPatientRepositories
    {
        public ISharedRepositories SharedRepositories { get; }
        public IMedicalRepository MedicalRepository { get; }
        public IPatientRepository PatientRepository { get; }
        public IPatientRecordRepository PatientRecordRepository { get; }

        public PatientRepositories(
            ISharedRepositories sharedRepositories,
            IMedicalRepository medicalRepository,
            IPatientRepository patientRepository,
            IPatientRecordRepository patientRecordRepository)
        {
            SharedRepositories = sharedRepositories;
            MedicalRepository = medicalRepository;
            PatientRepository = patientRepository;
            PatientRecordRepository = patientRecordRepository;
        }
    }
}
