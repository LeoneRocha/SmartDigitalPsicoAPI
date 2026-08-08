using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Patient.PatientAdditionalInformation;
using SmartDigitalPsicoAPI.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    /// <summary>
    /// Interface (contrato) responsável por IPatientAdditionalInformationService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IPatientAdditionalInformationService : SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<PatientAdditionalInformation, GetPatientAdditionalInformationDto>
    { 
        /// <summary>
        /// Método FindAllByPatient: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<List<GetPatientAdditionalInformationDto>>> FindAllByPatient(long patientId);
    }
}
