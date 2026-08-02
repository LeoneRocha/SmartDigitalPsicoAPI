using SmartDigitalPsico.Domain.Validation.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service.Schedule
{
    public interface IScheduleConflictService
    {
        Task<ServiceResponse<bool>> HasNoConflictAsync(ScheduleCalendarConflictRequest request);
    }
}
