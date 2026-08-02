using Serilog;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Core
{
    /// <summary>
    /// Generic booking/cancel/delete against ScheduleCalendar SoT.
    /// </summary>
    public class ScheduleCalendarBookingService : IScheduleBookingEngine
    {
        private readonly IScheduleCalendarService _scheduleService;
        private readonly IScheduleCalendarRepository _repository;
        private readonly ILogger _logger;

        public ScheduleCalendarBookingService(
            IScheduleCalendarService scheduleService,
            IScheduleCalendarRepository repository,
            ILogger logger)
        {
            _scheduleService = scheduleService;
            _repository = repository;
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
            return _scheduleService.CreateOrUpdateAsync(write);
        }

        public async Task<ServiceResponse<ScheduleCancelResult>> CancelAsync(ScheduleCancelRequest request)
        {
            var response = new ServiceResponse<ScheduleCancelResult>();
            try
            {
                var tenant = ScheduleKeyHelper.RequireTenant(request.TenantKey);
                var item = await _repository.GetItemAsync(tenant, request.OwnerKey, request.SubjectKey, request.AppointmentDateTime);
                if (item == null)
                {
                    response.Success = false;
                    response.Message = "Appointment not found.";
                    return response;
                }

                var packages = await _repository.GetOverlappingByOwnerAsync(
                    tenant, request.OwnerKey, request.AppointmentDateTime, request.AppointmentDateTime.AddMinutes(1));

                var package = packages.FirstOrDefault(p =>
                    (request.SubjectKey == null || p.SubjectKey == null || p.SubjectKey == request.SubjectKey)
                    && p.ScheduleData != null
                    && p.ScheduleData.Any(i => i.StartDateTime == item.StartDateTime));

                if (package == null)
                {
                    response.Success = false;
                    response.Message = "Appointment package not found.";
                    return response;
                }

                var newStatus = item.Status;
                for (var i = 0; i < package.ScheduleData.Length; i++)
                {
                    var entry = package.ScheduleData[i];
                    if (entry.StartDateTime != item.StartDateTime)
                        continue;

                    if (entry.Status == EStatusCalendar.PendingConfirmation)
                        entry.Status = EStatusCalendar.Canceled;
                    else if (entry.Status == EStatusCalendar.Confirmed)
                        entry.Status = EStatusCalendar.PendingCancellation;

                    entry.ReasonCancellation = request.Reason ?? string.Empty;
                    newStatus = entry.Status;
                }

                package.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                await _repository.Update(package);

                response.Success = true;
                response.Data = new ScheduleCancelResult
                {
                    PackageId = package.Id,
                    UniqueToken = package.UniqueToken,
                    NewStatus = newStatus
                };
                return response;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "ScheduleCalendarBookingService.CancelAsync failed");
                response.Success = false;
                response.Message = ex.Message;
                return response;
            }
        }

        public async Task<ServiceResponse<bool>> DeleteByTokenAsync(ScheduleDeleteTokenRequest request)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                var packages = await _repository.GetByTokenAsync(request.UniqueToken, request.OwnerKey, request.SubjectKey);
                if (packages.Length == 0)
                {
                    var byToken = await _repository.GetByUniqueTokenAsync(request.UniqueToken);
                    if (byToken != null)
                        packages = [byToken];
                }

                if (packages.Length == 0)
                {
                    response.Success = false;
                    response.Data = false;
                    response.Message = "Agenda schedule not found.";
                    return response;
                }

                await _repository.DeleteRangeAsync(packages);
                response.Success = true;
                response.Data = true;
                return response;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "ScheduleCalendarBookingService.DeleteByTokenAsync failed");
                response.Success = false;
                response.Message = ex.Message;
                return response;
            }
        }

        public Task<ServiceResponse<bool>> DeleteByIdAsync(long id)
            => _scheduleService.DeleteByIdAsync(id);
    }
}
