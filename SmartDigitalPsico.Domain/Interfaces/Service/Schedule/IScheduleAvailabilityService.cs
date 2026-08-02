using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service.Schedule
{
    public interface IScheduleAvailabilityService
    {
        Task<ServiceResponse<ScheduleGradeResult>> BuildGradeAsync(ScheduleGradeRequest request);
    }
}
