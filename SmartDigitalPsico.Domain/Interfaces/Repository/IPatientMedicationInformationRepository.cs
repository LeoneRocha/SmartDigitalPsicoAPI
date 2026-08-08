using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interface (contrato) responsável por IPatientMedicationInformationRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IPatientMedicationInformationRepository : SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<PatientMedicationInformation>
    {
        /// <summary>
        /// Método FindAllByPatient: consulta e retorna dados.
        /// </summary>
        Task<List<PatientMedicationInformation>> FindAllByPatient(long patientId);
    }
}
