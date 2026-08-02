using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service.Schedule
{
    public interface IScheduleQueryService
    {
        Task<ServiceResponse<ScheduleCalendar?>> GetByTokenAsync(string uniqueToken);
        Task<ServiceResponse<ScheduleCalendar?>> GetByIdAsync(long id);
        Task<ServiceResponse<ScheduleCalendar[]>> GetOverlappingPeriodAsync(string tenantKey, string ownerKey, DateTime start, DateTime end);
        Task<ServiceResponse<ScheduleCalendarItem[]>> GetItemsForOwnerAsync(string tenantKey, string ownerKey, DateTime start, DateTime end);
        Task<ServiceResponse<ScheduleCalendarItem?>> GetItemAsync(string tenantKey, string ownerKey, string? subjectKey, DateTime appointmentDateTime);
        Task<ServiceResponse<bool>> HasConflictAsync(string tenantKey, string ownerKey, DateTime appointmentDateTime);
    }
}
