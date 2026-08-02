using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service.Schedule
{
    public interface IScheduleUpdateService
    {
        Task<ServiceResponse<ScheduleCalendar>> UpdateAsync(ScheduleCalendarWriteRequest request);
        Task<ServiceResponse<ScheduleCancelResult>> CancelOccurrenceAsync(ScheduleCancelRequest request);
    }
}
