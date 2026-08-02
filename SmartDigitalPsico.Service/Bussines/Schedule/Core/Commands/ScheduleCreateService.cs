using Serilog;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.Validation.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Core.Commands
{
    public class ScheduleCreateService : IScheduleCreateService
    {
        private readonly IScheduleCalendarRepository _repository;
        private readonly IScheduleConflictService _conflictService;
        private readonly ILogger _logger;

        public ScheduleCreateService(
            IScheduleCalendarRepository repository,
            IScheduleConflictService conflictService,
            ILogger logger)
        {
            _repository = repository;
            _conflictService = conflictService;
            _logger = logger;
        }

        public Task<ServiceResponse<ScheduleCalendar>> BookAsync(ScheduleBookRequest request)
        {
            var write = new ScheduleCalendarWriteRequest
            {
                TenantKey = request.TenantKey,
                OwnerKey = request.OwnerKey,
                SubjectKey = request.SubjectKey,
                UniqueToken = string.IsNullOrWhiteSpace(request.UniqueToken) ? Guid.NewGuid().ToString() : request.UniqueToken,
                Enable = true,
                IsUpdate = false,
                UpdateSeries = true,
                Items = [request.Item]
            };
            write.Items[0].TokenRecurrence = write.UniqueToken;
            return CreateAsync(write);
        }

        public async Task<ServiceResponse<ScheduleCalendar>> CreateAsync(ScheduleCalendarWriteRequest request)
        {
            var response = new ServiceResponse<ScheduleCalendar>();
            try
            {
                if (string.IsNullOrWhiteSpace(request.OwnerKey)
                    || string.IsNullOrWhiteSpace(request.TenantKey)
                    || request.Items == null
                    || request.Items.Length == 0)
                {
                    response.Success = false;
                    response.Message = "TenantKey, OwnerKey and Items are required.";
                    return response;
                }

                if (string.IsNullOrWhiteSpace(request.UniqueToken))
                    request.UniqueToken = Guid.NewGuid().ToString();

                var token = request.UniqueToken.Trim();
                var existing = await _repository.GetByUniqueTokenAsync(token);
                if (existing != null)
                {
                    response.Success = false;
                    response.Message = "Agenda schedule already exists for UniqueToken. Use update.";
                    return response;
                }

                var conflict = await EnsureNoConflictAsync(request, token);
                if (conflict != null)
                    return conflict;

                var now = DateHelper.GetDateTimeNowFromUtc();
                var (startPeriod, endPeriod) = ComputePeriod(request.Items);
                var entity = new ScheduleCalendar
                {
                    Enable = request.Enable,
                    CreatedDate = now,
                    ModifyDate = now,
                    LastAccessDate = now,
                    UniqueToken = token,
                    TenantKey = ScheduleKeyHelper.RequireTenant(request.TenantKey),
                    OwnerKey = request.OwnerKey,
                    SubjectKey = request.SubjectKey,
                    StartPeriod = startPeriod,
                    EndPeriod = endPeriod,
                    ScheduleData = request.Items
                };
                entity = await _repository.Create(entity);

                response.Data = entity;
                response.Success = true;
                response.Message = "Agenda schedule saved.";
                return response;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "ScheduleCreateService.CreateAsync failed. Inner={Inner}", ex.InnerException?.Message);
                response.Success = false;
                response.Message = ex.InnerException?.Message ?? ex.Message;
                return response;
            }
        }

        private async Task<ServiceResponse<ScheduleCalendar>?> EnsureNoConflictAsync(
            ScheduleCalendarWriteRequest request, string token)
        {
            foreach (var item in request.Items)
            {
                var check = await _conflictService.HasNoConflictAsync(new ScheduleCalendarConflictRequest
                {
                    TenantKey = request.TenantKey,
                    OwnerKey = request.OwnerKey,
                    StartDateTime = item.StartDateTime,
                    EndDateTime = item.EndDateTime,
                    ExcludeToken = token
                });
                if (!check.Success || check.Data == false)
                {
                    return new ServiceResponse<ScheduleCalendar>
                    {
                        Success = false,
                        Message = check.Message ?? "There is a scheduling conflict for the specified time."
                    };
                }
            }
            return null;
        }

        private static (DateTime start, DateTime end) ComputePeriod(ScheduleCalendarItem[] items)
        {
            var start = items.Min(i => i.StartDateTime);
            var end = items.Max(i => i.EndDateTime ?? i.StartDateTime);
            return (start, end);
        }
    }
}
