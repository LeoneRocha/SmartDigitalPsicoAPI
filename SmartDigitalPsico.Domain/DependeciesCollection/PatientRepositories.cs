using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Medical;
using SmartDigitalPsico.Domain.Interfaces.Patient;

namespace SmartDigitalPsico.Domain.DependeciesCollection
{
    /// <summary>
    /// Classe responsável por PatientRepositories.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class PatientRepositories : IPatientRepositories
    {
        public ISharedRepositories SharedRepositories { get; }
        public IMedicalRepository MedicalRepository { get; }
        public IPatientRepository PatientRepository { get; }
        public IPatientRecordRepository PatientRecordRepository { get; }

        /// <summary>
        /// Método PatientRepositories: executa a operação PatientRepositories.
        /// </summary>
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
