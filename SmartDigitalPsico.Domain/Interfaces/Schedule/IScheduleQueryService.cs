using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Domain.EntityModels.Schedule;

namespace SmartDigitalPsico.Domain.Interfaces.Schedule
{
    /// <summary>
    /// Interface (contrato) responsável por IScheduleQueryService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IScheduleQueryService
    {
        /// <summary>
        /// Método GetByTokenAsync: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<ScheduleCalendar?>> GetByTokenAsync(string uniqueToken);
        /// <summary>
        /// Método GetByIdAsync: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<ScheduleCalendar?>> GetByIdAsync(long id);
        /// <summary>
        /// Método GetOverlappingPeriodAsync: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<ScheduleCalendar[]>> GetOverlappingPeriodAsync(string tenantKey, string ownerKey, DateTime start, DateTime end);
        /// <summary>
        /// Método GetItemsForOwnerAsync: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<ScheduleCalendarItem[]>> GetItemsForOwnerAsync(string tenantKey, string ownerKey, DateTime start, DateTime end);
        /// <summary>
        /// Método GetItemAsync: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<ScheduleCalendarItem?>> GetItemAsync(string tenantKey, string ownerKey, string? subjectKey, DateTime appointmentDateTime);
        /// <summary>
        /// Método HasConflictAsync: executa a operação HasConflictAsync.
        /// </summary>
        Task<ServiceResponse<bool>> HasConflictAsync(string tenantKey, string ownerKey, DateTime appointmentDateTime);
    }
}
