using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service.Schedule
{
    public interface IScheduleAppointmentQueryService
    {
        Task<ServiceResponse<ScheduleCalendarItem[]>> GetItemsForOwnerSubjectAsync(
            string tenantKey, string ownerKey, string? subjectKey, DateTime start, DateTime end);
    }
}
