using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service.Schedule
{
    /// <summary>
    /// Generic calendar grade/availability engine (ownerKey + constraints). No Medical DTOs.
    /// </summary>
    public interface IScheduleGradeEngine
    {
        Task<ServiceResponse<ScheduleGradeResult>> BuildGradeAsync(ScheduleGradeRequest request);
    }
}
