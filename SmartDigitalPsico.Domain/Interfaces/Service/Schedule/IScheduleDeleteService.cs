using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service.Schedule
{
    public interface IScheduleDeleteService
    {
        Task<ServiceResponse<bool>> DeleteByTokenAsync(string uniqueToken);
        Task<ServiceResponse<bool>> DeleteByTokenFilteredAsync(ScheduleDeleteTokenRequest request);
        Task<ServiceResponse<bool>> DeleteByIdAsync(long id);
    }
}
