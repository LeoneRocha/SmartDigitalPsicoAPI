using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.DTO.Patient.ADD;
using SmartDigitalPsico.Domain.DTO.Patient.GET;
using SmartDigitalPsico.Domain.DTO.Patient.UPDATE;
using SmartDigitalPsico.Domain.DTO.Patient.Common;
using SmartDigitalPsico.Core.SDK.Domain.VO;

using PatientEntity = SmartDigitalPsico.Domain.ModelEntity.Patient;

using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Patient
{
    /// <summary>
    /// Interface (contrato) responsável por IPatientService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IPatientService : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<PatientEntity, GetPatientDto>
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
