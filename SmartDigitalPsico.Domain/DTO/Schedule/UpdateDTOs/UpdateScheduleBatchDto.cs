using SmartDigitalPsico.Domain.DTO.Schedule.UpdateDTOs;

namespace SmartDigitalPsico.Domain.DTO.Schedule
{
    public class UpdateScheduleBatchDto : ScheduleBatchBaseDto
    {
        public long Id { get; set; }
        public UpdateScheduleItemDto[] ScheduleItems { get; set; } = Array.Empty<UpdateScheduleItemDto>();
    }
}
