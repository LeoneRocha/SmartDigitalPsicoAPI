using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Schedule;
namespace SmartDigitalPsico.Service
{
    /// <summary>
    /// Classe responsável por ScheduleAppointmentQueryService.
    /// Responsabilidade: módulo de agendamento (Schedule).
    /// Relação: orquestra Core Schedule e contratos Medical do Domain.
    /// </summary>
    public class ScheduleAppointmentQueryService : IScheduleAppointmentQueryService
    {
        private readonly IScheduleCalendarRepository _repository;

        /// <summary>
        /// Método ScheduleAppointmentQueryService: operação de agendamento.
        /// </summary>
        public ScheduleAppointmentQueryService(IScheduleCalendarRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Método GetItemsForOwnerSubjectAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<ScheduleCalendarItem[]>> GetItemsForOwnerSubjectAsync(
            string tenantKey, string ownerKey, string? subjectKey, DateTime start, DateTime end)
        {
            var tenant = ScheduleKeyHelper.RequireTenant(tenantKey);
            var data = await _repository.GetItemsForOwnerSubjectAsync(tenant, ownerKey, subjectKey, start, end);
            return new ServiceResponse<ScheduleCalendarItem[]> { Data = data, Success = true };
        }
    }
}
