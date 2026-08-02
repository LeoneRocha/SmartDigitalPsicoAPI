using Serilog;
using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Core
{
    /// <summary>
    /// Generic ScheduleCalendar SoT service — no Medical/Patient dependencies.
    /// </summary>
    public class ScheduleCalendarService : IScheduleCalendarService
    {
        private readonly IScheduleCalendarRepository _repository;
        private readonly ILogger _logger;

        public ScheduleCalendarService(IScheduleCalendarRepository repository, ILogger logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<ServiceResponse<ScheduleCalendar>> CreateOrUpdateAsync(ScheduleCalendarWriteRequest request)
        {
            var response = new ServiceResponse<ScheduleCalendar>();
            try
            {
                if (string.IsNullOrWhiteSpace(request.UniqueToken)
                    || string.IsNullOrWhiteSpace(request.OwnerKey)
                    || request.Items == null
                    || request.Items.Length == 0)
                {
                    response.Success = false;
                    response.Message = "UniqueToken, OwnerKey and Items are required.";
                    return response;
                }

                var token = request.UniqueToken.Trim();
                var now = DateHelper.GetDateTimeNowFromUtc();
                var (startPeriod, endPeriod) = ComputePeriod(request.Items);

                var entity = await _repository.GetByUniqueTokenAsync(token);
                if (entity == null)
                {
                    entity = new ScheduleCalendar
                    {
                        Enable = request.Enable,
                        CreatedDate = now,
                        ModifyDate = now,
                        LastAccessDate = now,
                        UniqueToken = token,
                        TenantKey = ScheduleKeyHelper.ForTenant(request.TenantKey),
                        OwnerKey = request.OwnerKey,
                        SubjectKey = request.SubjectKey,
                        StartPeriod = startPeriod,
                        EndPeriod = endPeriod,
                        ScheduleData = request.Items
                    };
                    entity = await _repository.Create(entity);
                }
                else
                {
                    entity.Enable = request.Enable;
                    entity.ModifyDate = now;
                    entity.LastAccessDate = now;
                    entity.TenantKey = ScheduleKeyHelper.ForTenant(request.TenantKey);
                    entity.OwnerKey = request.OwnerKey;
                    entity.SubjectKey = request.SubjectKey;
                    if (request.UpdateSeries || request.IsUpdate)
                    {
                        entity.StartPeriod = startPeriod;
                        entity.EndPeriod = endPeriod;
                        entity.ScheduleData = request.Items;
                    }
                    entity = await _repository.Update(entity);
                }

                response.Data = entity;
                response.Success = true;
                response.Message = "Agenda schedule saved.";
                return response;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "ScheduleCalendarService.CreateOrUpdateAsync failed");
                response.Success = false;
                response.Message = ex.Message;
                return response;
            }
        }

        public async Task<ServiceResponse<bool>> DeleteByTokenAsync(string uniqueToken)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                var entity = await _repository.GetByUniqueTokenAsync(uniqueToken);
                if (entity == null)
                {
                    response.Success = false;
                    response.Data = false;
                    response.Message = "Agenda schedule not found.";
                    return response;
                }

                await _repository.Delete(entity.Id);
                response.Success = true;
                response.Data = true;
                return response;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "ScheduleCalendarService.DeleteByTokenAsync failed");
                response.Success = false;
                response.Message = ex.Message;
                return response;
            }
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
                _logger.Error(ex, "ScheduleCalendarService.GetByIdAsync failed");
                return new ServiceResponse<ScheduleCalendar?> { Success = false, Message = ex.Message };
            }
        }

        public async Task<ServiceResponse<bool>> DeleteByIdAsync(long id)
        {
            var response = new ServiceResponse<bool>();
            try
            {
                if (!await _repository.Exists(id))
                {
                    response.Success = false;
                    response.Data = false;
                    response.Message = "Agenda schedule not found.";
                    return response;
                }

                await _repository.Delete(id);
                response.Success = true;
                response.Data = true;
                return response;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "ScheduleCalendarService.DeleteByIdAsync failed");
                response.Success = false;
                response.Message = ex.Message;
                return response;
            }
        }

        public async Task<ServiceResponse<ScheduleCalendar[]>> GetOverlappingPeriodAsync(string tenantKey, string ownerKey, DateTime start, DateTime end)
        {
            var tenant = ScheduleKeyHelper.ForTenant(tenantKey);
            var data = await _repository.GetOverlappingByOwnerAsync(tenant, ownerKey, start, end);
            return new ServiceResponse<ScheduleCalendar[]> { Data = data, Success = true };
        }

        public async Task<ServiceResponse<ScheduleCalendarItem[]>> GetItemsForOwnerAsync(string tenantKey, string ownerKey, DateTime start, DateTime end)
        {
            var tenant = ScheduleKeyHelper.ForTenant(tenantKey);
            var data = await _repository.GetItemsForOwnerAsync(tenant, ownerKey, start, end);
            return new ServiceResponse<ScheduleCalendarItem[]> { Data = data, Success = true };
        }

        public async Task<ServiceResponse<ScheduleCalendarItem[]>> GetItemsForOwnerSubjectAsync(string tenantKey, string ownerKey, string? subjectKey, DateTime start, DateTime end)
        {
            var tenant = ScheduleKeyHelper.ForTenant(tenantKey);
            var data = await _repository.GetItemsForOwnerSubjectAsync(tenant, ownerKey, subjectKey, start, end);
            return new ServiceResponse<ScheduleCalendarItem[]> { Data = data, Success = true };
        }

        public async Task<ServiceResponse<ScheduleCalendarItem?>> GetItemAsync(string tenantKey, string ownerKey, string? subjectKey, DateTime appointmentDateTime)
        {
            var tenant = ScheduleKeyHelper.ForTenant(tenantKey);
            var data = await _repository.GetItemAsync(tenant, ownerKey, subjectKey, appointmentDateTime);
            return new ServiceResponse<ScheduleCalendarItem?> { Data = data, Success = true };
        }

        public async Task<ServiceResponse<bool>> HasConflictAsync(string tenantKey, string ownerKey, DateTime appointmentDateTime)
        {
            var tenant = ScheduleKeyHelper.ForTenant(tenantKey);
            var hasConflict = await _repository.HasConflictAsync(tenant, ownerKey, appointmentDateTime);
            return new ServiceResponse<bool> { Data = hasConflict, Success = true };
        }

        private static (DateTime start, DateTime end) ComputePeriod(ScheduleCalendarItem[] items)
        {
            var start = items.Min(i => i.StartDateTime);
            var end = items.Max(i => i.EndDateTime ?? i.StartDateTime);
            return (start, end);
        }
    }
}
