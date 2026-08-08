using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Core.SDK.Domain.VO;

using SmartDigitalPsico.Domain.Interfaces.Schedule;
namespace SmartDigitalPsico.Service.Schedule.Core.Queries
{
    using User = SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = SmartDigitalPsico.Domain.EntityModels.Specialty;
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
