using Serilog;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Core.Queries
{
    public class ScheduleQueryService : IScheduleQueryService
    {
        private readonly IScheduleCalendarRepository _repository;
        private readonly IScheduleConflictService _conflictService;
        private readonly ILogger _logger;

        public ScheduleQueryService(
            IScheduleCalendarRepository repository,
            IScheduleConflictService conflictService,
            ILogger logger)
        {
            _repository = repository;
            _conflictService = conflictService;
            _logger = logger;
        }

        public async Task<ServiceResponse<ScheduleCalendar?>> GetByTokenAsync(string uniqueToken)
        {
            return new ServiceResponse<ScheduleCalendar?>
            {
                Data = await _repository.GetByUniqueTokenAsync(uniqueToken),
                Success = true
            };
        }

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

        public async Task<ServiceResponse<ScheduleCalendar[]>> GetOverlappingPeriodAsync(
            string tenantKey, string ownerKey, DateTime start, DateTime end)
        {
            var tenant = ScheduleKeyHelper.RequireTenant(tenantKey);
            var data = await _repository.GetOverlappingByOwnerAsync(tenant, ownerKey, start, end);
            return new ServiceResponse<ScheduleCalendar[]> { Data = data, Success = true };
        }

        public async Task<ServiceResponse<ScheduleCalendarItem[]>> GetItemsForOwnerAsync(
            string tenantKey, string ownerKey, DateTime start, DateTime end)
        {
            var tenant = ScheduleKeyHelper.RequireTenant(tenantKey);
            var data = await _repository.GetItemsForOwnerAsync(tenant, ownerKey, start, end);
            return new ServiceResponse<ScheduleCalendarItem[]> { Data = data, Success = true };
        }

        public async Task<ServiceResponse<ScheduleCalendarItem?>> GetItemAsync(
            string tenantKey, string ownerKey, string? subjectKey, DateTime appointmentDateTime)
        {
            var tenant = ScheduleKeyHelper.RequireTenant(tenantKey);
            var data = await _repository.GetItemAsync(tenant, ownerKey, subjectKey, appointmentDateTime);
            return new ServiceResponse<ScheduleCalendarItem?> { Data = data, Success = true };
        }

        public async Task<ServiceResponse<bool>> HasConflictAsync(string tenantKey, string ownerKey, DateTime appointmentDateTime)
        {
            var noConflict = await _conflictService.HasNoConflictAsync(new Domain.Validation.Schedule.ScheduleCalendarConflictRequest
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
