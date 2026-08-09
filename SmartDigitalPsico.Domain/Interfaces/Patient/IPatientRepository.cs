using SmartDigitalPsico.Domain.DTO.Patient.Common;

using PatientEntity = SmartDigitalPsico.Domain.EntityModels.Patient;

namespace SmartDigitalPsico.Domain.Interfaces.Patient
{
    /// <summary>
    /// Interface (contrato) responsável por IPatientRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IPatientRepository : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<PatientEntity>
    {
        /// <summary>
        /// Método FindAllByMedicalId: consulta e retorna dados.
        /// </summary>
        Task<List<PatientEntity>> FindAllByMedicalId(long medicalId);
        /// <summary>
        /// Método FindByEmail: consulta e retorna dados.
        /// </summary>
        Task<PatientEntity?> FindByEmail(string email);
        /// <summary>
        /// Método FindByPatient: consulta e retorna dados.
        /// </summary>
        Task<PatientEntity> FindByPatient(PatientEntity patient);
        /// <summary>
        /// Método GetPatientDetailsByIdAsync: consulta e retorna dados.
        /// </summary>
        Task<PatientEntity> GetPatientDetailsByIdAsync(long id);
        /// <summary>
        /// Método PatientSearch: executa a operação PatientSearch.
        /// </summary>
        Task<List<PatientEntity>> PatientSearch(PatientSearchCriteriaDto patientSearchCriteriaDto);
    }
}
