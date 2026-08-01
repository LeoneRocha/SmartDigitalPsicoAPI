using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Schedule
{
    public class AddScheduleBatchDto : ScheduleBatchBaseDto, IEntityDtoAdd
    {
        public AddScheduleItemDto[] ScheduleItems { get; set; } = Array.Empty<AddScheduleItemDto>();
    }
}
