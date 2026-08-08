using SmartDigitalPsico.Domain.DTO.Patient.ADD;
using SmartDigitalPsico.Domain.DTO.Patient.GET;
using SmartDigitalPsico.Domain.DTO.Patient.UPDATE;
using SmartDigitalPsico.Domain.DTO.Patient.Common;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interface (contrato) responsável por IPatientRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IPatientRepository : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<Patient>
    {
        /// <summary>
        /// Método FindAllByMedicalId: consulta e retorna dados.
        /// </summary>
        Task<List<Patient>> FindAllByMedicalId(long medicalId);
        /// <summary>
        /// Método FindByEmail: consulta e retorna dados.
        /// </summary>
        Task<Patient?> FindByEmail(string email);
        /// <summary>
        /// Método FindByPatient: consulta e retorna dados.
        /// </summary>
        Task<Patient> FindByPatient(Patient patient);
        /// <summary>
        /// Método GetPatientDetailsByIdAsync: consulta e retorna dados.
        /// </summary>
        Task<Patient> GetPatientDetailsByIdAsync(long id);
        /// <summary>
        /// Método PatientSearch: executa a operação PatientSearch.
        /// </summary>
        Task<List<Patient>> PatientSearch(PatientSearchCriteriaDto patientSearchCriteriaDto);
    }
}
