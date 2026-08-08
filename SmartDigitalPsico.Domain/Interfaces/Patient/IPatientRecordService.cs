using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Patient.ADD;
using SmartDigitalPsico.Domain.DTO.Patient.GET;
using SmartDigitalPsico.Domain.DTO.Patient.UPDATE;
using SmartDigitalPsico.Domain.DTO.Patient.Common;
using SmartDigitalPsico.Core.SDK.Domain.VO;

using PatientEntity = SmartDigitalPsico.Domain.ModelEntity.Patient;

namespace SmartDigitalPsico.Domain.Interfaces.Patient
{
    /// <summary>
    /// Interface (contrato) responsável por IPatientRecordService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IPatientRecordService : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<PatientRecord, GetPatientRecordDto>
    { 
        /// <summary>
        /// Método FindAllByPatient: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<List<GetPatientRecordDto>>> FindAllByPatient(long patientId);
    }
}
