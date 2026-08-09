using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using SmartDigitalPsico.Core.SDK.Domain.VO;

using SmartDigitalPsico.Domain.Interfaces.Schedule;
using SmartDigitalPsico.Domain.EntityModels;
namespace SmartDigitalPsico.Service
{
                                    /// <summary>
    /// Classe responsável por ScheduleQueryService.
    /// Responsabilidade: módulo de agendamento (Schedule).
    /// Relação: orquestra Core Schedule e contratos Medical do Domain.
    /// </summary>
    public class ScheduleQueryService : IScheduleQueryService
    {
        private readonly IScheduleCalendarRepository _repository;
        private readonly IScheduleConflictService _conflictService;
        private readonly IAppLogger _logger;

        /// <summary>
        /// Método ScheduleQueryService: operação de agendamento.
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
        /// Método GetByTokenAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<ScheduleCalendar?>> GetByTokenAsync(string uniqueToken)
        {
            return new ServiceResponse<ScheduleCalendar?>
            {
                Data = await _repository.GetByUniqueTokenAsync(uniqueToken),
                Success = true
            };
        }

        /// <summary>
        /// Método GetByIdAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<ScheduleCalendar?>> GetByIdAsync(long id)
        {
            try
            {
                var entity = await _repository.FindByID(id);
                return new ServiceResponse<ScheduleCalendar?> { Data = entity, Success = entity != null };
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "ScheduleQueryService.GetByIdAsync failed");
                return new ServiceResponse<ScheduleCalendar?> { Success = false, Message = ex.Message };
            }
        }

        /// <summary>
        /// Método GetOverlappingPeriodAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<ScheduleCalendar[]>> GetOverlappingPeriodAsync(
            string tenantKey, string ownerKey, DateTime start, DateTime end)
        {
            var tenant = ScheduleKeyHelper.RequireTenant(tenantKey);
            var data = await _repository.GetOverlappingByOwnerAsync(tenant, ownerKey, start, end);
            return new ServiceResponse<ScheduleCalendar[]> { Data = data, Success = true };
        }

        /// <summary>
        /// Método GetItemsForOwnerAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<ScheduleCalendarItem[]>> GetItemsForOwnerAsync(
            string tenantKey, string ownerKey, DateTime start, DateTime end)
        {
            var tenant = ScheduleKeyHelper.RequireTenant(tenantKey);
            var data = await _repository.GetItemsForOwnerAsync(tenant, ownerKey, start, end);
            return new ServiceResponse<ScheduleCalendarItem[]> { Data = data, Success = true };
        }

        /// <summary>
        /// Método GetItemAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<ScheduleCalendarItem?>> GetItemAsync(
            string tenantKey, string ownerKey, string? subjectKey, DateTime appointmentDateTime)
        {
            var tenant = ScheduleKeyHelper.RequireTenant(tenantKey);
            var data = await _repository.GetItemAsync(tenant, ownerKey, subjectKey, appointmentDateTime);
            return new ServiceResponse<ScheduleCalendarItem?> { Data = data, Success = true };
        }

        /// <summary>
        /// Método HasConflictAsync: executa a operação HasConflictAsync.
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
            return new ServiceResponse<bool>
            {
                Success = noConflict.Success,
                Data = noConflict.Success && !noConflict.Data,
                Message = noConflict.Message
            };
        }
    }
}
