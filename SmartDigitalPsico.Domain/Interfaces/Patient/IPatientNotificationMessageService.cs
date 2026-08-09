using SmartDigitalPsico.Domain.DTO.Patient.GET;
using SmartDigitalPsico.Core.SDK.Domain.VO;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Interfaces.Patient
{
    /// <summary>
    /// Interface (contrato) responsável por IPatientNotificationMessageService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IPatientNotificationMessageService : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<PatientNotificationMessage
, GetPatientNotificationMessageVO>
    {

        /// <summary>
        /// Método FindAllByPatient: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<List<GetPatientNotificationMessageVO>>> FindAllByPatient(long patientId);
    }
}
