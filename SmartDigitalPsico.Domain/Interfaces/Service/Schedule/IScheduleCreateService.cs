using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service.Schedule
{
    public interface IScheduleCreateService
    {
        Task<ServiceResponse<ScheduleCalendar>> CreateAsync(ScheduleCalendarWriteRequest request);
        Task<ServiceResponse<ScheduleCalendar>> BookAsync(ScheduleBookRequest request);
    }
}
