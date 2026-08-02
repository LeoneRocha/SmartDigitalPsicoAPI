using SmartDigitalPsico.Domain.DTO.Schedule;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service.Schedule
{
    /// <summary>
    /// Generic book/cancel/delete-by-token engine (no Medical DTOs).
    /// </summary>
    public interface IScheduleBookingEngine
    {
        Task<ServiceResponse<ScheduleCalendar>> BookAsync(ScheduleBookRequest request);
        Task<ServiceResponse<ScheduleCancelResult>> CancelAsync(ScheduleCancelRequest request);
        Task<ServiceResponse<bool>> DeleteByTokenAsync(ScheduleDeleteTokenRequest request);
        Task<ServiceResponse<bool>> DeleteByIdAsync(long id);
    }
}
