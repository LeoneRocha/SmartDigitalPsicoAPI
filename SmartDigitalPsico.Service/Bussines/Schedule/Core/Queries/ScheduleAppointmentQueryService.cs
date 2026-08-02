using SmartDigitalPsico.Domain.Helpers.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Repository.Schedule;
using SmartDigitalPsico.Domain.Interfaces.Service.Schedule;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.Bussines.Schedule.Core.Queries
{
    public class ScheduleAppointmentQueryService : IScheduleAppointmentQueryService
    {
        private readonly IScheduleCalendarRepository _repository;

        public ScheduleAppointmentQueryService(IScheduleCalendarRepository repository)
        {
            _repository = repository;
        }

        public async Task<ServiceResponse<ScheduleCalendarItem[]>> GetItemsForOwnerSubjectAsync(
            string tenantKey, string ownerKey, string? subjectKey, DateTime start, DateTime end)
        {
            var tenant = ScheduleKeyHelper.RequireTenant(tenantKey);
            var data = await _repository.GetItemsForOwnerSubjectAsync(tenant, ownerKey, subjectKey, start, end);
            return new ServiceResponse<ScheduleCalendarItem[]> { Data = data, Success = true };
        }
    }
}
