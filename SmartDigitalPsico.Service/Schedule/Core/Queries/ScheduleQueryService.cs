using SmartDigitalPsico.Core.SDK.Domain.Extensions;
using SmartDigitalPsico.Core.SDK.Infrastructure.Logging;
using SmartCoreHub.Core.SDK.Infrastructure.Logging;
using IAppLogger = SmartCoreHub.Core.SDK.Domain.Interfaces.Common.IAppLogger;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Schedule;
namespace SmartDigitalPsico.Service
{
    /// <summary>
    /// Classe respons˜vel por ScheduleQueryService.
    /// Responsabilidade: m˜dulo de agendamento (Schedule).
    /// Rela˜˜o: orquestra Core Schedule e contratos Medical do Domain.
    /// </summary>
    public class ScheduleQueryService : IScheduleQueryService
    {
        private readonly IScheduleCalendarRepository _repository;
        private readonly IScheduleConflictService _conflictService;
        private readonly IAppLogger _logger;

        /// <summary>
        /// M˜todo ScheduleQueryService: opera˜˜o de agendamento.
        /// </summary>
        public ScheduleQueryService(
            IScheduleCalendarRepository repository,
            IScheduleConflictService conflictService,
            IAppLogger logger)
        {
            _repository = repository;
            _conflictService = conflictService;
            _logger = logger;
        }

        /// <summary>
        /// M˜todo GetByTokenAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<ScheduleCalendar?>> GetByTokenAsync(string uniqueToken)
        {
            return new ServiceResponse<ScheduleCalendar?>
            {
                Data = await _repository.GetByUniqueTokenAsync(uniqueToken),
            };
        }

        /// <summary>
        /// M˜todo GetByIdAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<ScheduleCalendar?>> GetByIdAsync(long id)
        {
            try
            {
                var entity = await _repository.FindByID(id);
                if (entity == null)
                    return new ServiceResponse<ScheduleCalendar?>().FailWith("Agenda schedule not found.", "GetByIdAsync");
                return new ServiceResponse<ScheduleCalendar?> { Data = entity };
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "ScheduleQueryService.GetByIdAsync failed");
                return new ServiceResponse<ScheduleCalendar?>().FailWith(ex.Message, "GetByIdAsync");
            }
        }

        /// <summary>
        /// M˜todo GetOverlappingPeriodAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<ScheduleCalendar[]>> GetOverlappingPeriodAsync(
            string tenantKey, string ownerKey, DateTime start, DateTime end)
        {
            var tenant = ScheduleKeyHelper.RequireTenant(tenantKey);
            var data = await _repository.GetOverlappingByOwnerAsync(tenant, ownerKey, start, end);
            return new ServiceResponse<ScheduleCalendar[]> { Data = data };
        }

        /// <summary>
        /// M˜todo GetItemsForOwnerAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<ScheduleCalendarItem[]>> GetItemsForOwnerAsync(
            string tenantKey, string ownerKey, DateTime start, DateTime end)
        {
            var tenant = ScheduleKeyHelper.RequireTenant(tenantKey);
            var data = await _repository.GetItemsForOwnerAsync(tenant, ownerKey, start, end);
            return new ServiceResponse<ScheduleCalendarItem[]> { Data = data };
        }

        /// <summary>
        /// M˜todo GetItemAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<ScheduleCalendarItem?>> GetItemAsync(
            string tenantKey, string ownerKey, string? subjectKey, DateTime appointmentDateTime)
        {
            var tenant = ScheduleKeyHelper.RequireTenant(tenantKey);
            var data = await _repository.GetItemAsync(tenant, ownerKey, subjectKey, appointmentDateTime);
            return new ServiceResponse<ScheduleCalendarItem?> { Data = data };
        }

        /// <summary>
        /// M˜todo HasConflictAsync: executa a opera˜˜o HasConflictAsync.
        /// </summary>
        public async Task<ServiceResponse<bool>> HasConflictAsync(string tenantKey, string ownerKey, DateTime appointmentDateTime)
        {
            var noConflict = await _conflictService.HasNoConflictAsync(new Domain.Validation.ScheduleCalendarConflictRequest
            {
                TenantKey = tenantKey,
                OwnerKey = ownerKey,
                StartDateTime = appointmentDateTime,
                EndDateTime = appointmentDateTime.AddMinutes(1)
            });
            var response = new ServiceResponse<bool>
            {
                Data = noConflict.Success && !noConflict.Data,
                Message = noConflict.Message,
                Errors = noConflict.Errors
            };
            if (!noConflict.Success && (response.Errors == null || response.Errors.Count == 0) && !string.IsNullOrEmpty(noConflict.Message))
                response.FailWith(noConflict.Message, "HasConflictAsync");
            return response;
        }
    }
}
