using SmartDigitalPsico.Domain.ModelEntity;

using PatientEntity = SmartDigitalPsico.Domain.ModelEntity.Patient;

namespace SmartDigitalPsico.Domain.Interfaces.Patient
{
    /// <summary>
    /// Interface (contrato) responsável por IPatientMedicationInformationRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IPatientMedicationInformationRepository : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<PatientMedicationInformation>
    {
        /// <summary>
        /// Método FindAllByPatient: consulta e retorna dados.
        /// </summary>
        Task<List<PatientMedicationInformation>> FindAllByPatient(long patientId);
    }
}
