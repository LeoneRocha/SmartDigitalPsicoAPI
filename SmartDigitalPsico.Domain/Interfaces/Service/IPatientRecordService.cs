using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Patient.PatientRecord;
using SmartDigitalPsicoAPI.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    /// <summary>
    /// Interface (contrato) responsável por IPatientRecordService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IPatientRecordService : SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<PatientRecord, GetPatientRecordDto>
    { 
        /// <summary>
        /// Método FindAllByPatient: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<List<GetPatientRecordDto>>> FindAllByPatient(long patientId);
    }
}
