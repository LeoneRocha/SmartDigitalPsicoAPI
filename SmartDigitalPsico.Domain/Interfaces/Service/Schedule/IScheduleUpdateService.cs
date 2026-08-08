using SmartDigitalPsico.Domain.DTO.Schedule.Common;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service.Schedule
{
    /// <summary>
    /// Interface (contrato) responsável por IScheduleUpdateService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IScheduleUpdateService
    {
        /// <summary>
        /// Método UpdateAsync: atualiza um registro/recurso existente.
        /// </summary>
        Task<ServiceResponse<ScheduleCalendar>> UpdateAsync(ScheduleCalendarWriteRequest request);
        /// <summary>
        /// Método CancelOccurrenceAsync: remove ou cancela um registro/recurso.
        /// </summary>
        Task<ServiceResponse<ScheduleCancelResult>> CancelOccurrenceAsync(ScheduleCancelRequest request);
    }
}
