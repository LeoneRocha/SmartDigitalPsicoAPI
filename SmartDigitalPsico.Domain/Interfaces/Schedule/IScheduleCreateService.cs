using SmartDigitalPsico.Domain.DTO.Schedule.Common;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Schedule
{
    /// <summary>
    /// Interface (contrato) responsável por IScheduleCreateService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IScheduleCreateService
    {
        /// <summary>
        /// Método CreateAsync: cria ou persiste um novo registro/recurso.
        /// </summary>
        Task<ServiceResponse<ScheduleCalendar>> CreateAsync(ScheduleCalendarWriteRequest request);
        /// <summary>
        /// Método BookAsync: mapeia, transforma ou agenda dados.
        /// </summary>
        Task<ServiceResponse<ScheduleCalendar>> BookAsync(ScheduleBookRequest request);
    }
}
