using SmartDigitalPsico.Domain.DTO.Schedule.UpdateDTOs;

namespace SmartDigitalPsico.Domain.DTO.Schedule
{
    public class UpdateScheduleBatchDto : ScheduleBatchBaseDto
    {
        public UpdateScheduleItemDto[] ScheduleItems { get; set; } = [];
    }
}
