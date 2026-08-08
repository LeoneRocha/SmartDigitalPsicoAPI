using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Patient.PatientMedicationInformation;
using SmartDigitalPsicoAPI.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    /// <summary>
    /// Interface (contrato) responsável por IPatientMedicationInformationService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IPatientMedicationInformationService 
        : SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<PatientMedicationInformation, GetPatientMedicationInformationDto>
    { 
        /// <summary>
        /// Método FindAllByPatient: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<List<GetPatientMedicationInformationDto>>> FindAllByPatient(long patientId);
    }
}
