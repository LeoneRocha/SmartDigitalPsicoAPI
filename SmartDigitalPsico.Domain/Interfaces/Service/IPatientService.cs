using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Patient;
using SmartDigitalPsicoAPI.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    /// <summary>
    /// Interface (contrato) responsável por IPatientService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IPatientService : SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<Patient, GetPatientDto>
    {
        /// <summary>
        /// Método FindAll: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<List<GetPatientDto>>> FindAll(long medicalId);
        /// <summary>
        /// Método FindByPatient: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<GetPatientDto>> FindByPatient(GetPatientDto info);
        /// <summary>
        /// Método PatientSearch: executa a operação PatientSearch.
        /// </summary>
        Task<ServiceResponse<List<GetPatientDto>>> PatientSearch(PatientSearchCriteriaDto patientSearchCriteriaDto);
    }
}
