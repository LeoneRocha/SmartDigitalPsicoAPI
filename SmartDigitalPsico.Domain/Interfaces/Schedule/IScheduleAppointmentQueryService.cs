using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Schedule
{
    /// <summary>
    /// Interface (contrato) responsável por IScheduleAppointmentQueryService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IScheduleAppointmentQueryService
    {
        /// <summary>
        /// Método GetItemsForOwnerSubjectAsync: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<ScheduleCalendarItem[]>> GetItemsForOwnerSubjectAsync(
            string tenantKey, string ownerKey, string? subjectKey, DateTime start, DateTime end);
    }
}
