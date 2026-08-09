using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Domain.DTO.Schedule.Common;

namespace SmartDigitalPsico.Domain.Interfaces.Schedule
{
    /// <summary>
    /// Interface (contrato) responsável por IScheduleAvailabilityService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IScheduleAvailabilityService
    {
        /// <summary>
        /// Método BuildGradeAsync: mapeia, transforma ou agenda dados.
        /// </summary>
        Task<ServiceResponse<ScheduleGradeResult>> BuildGradeAsync(ScheduleGradeRequest request);
    }
}
