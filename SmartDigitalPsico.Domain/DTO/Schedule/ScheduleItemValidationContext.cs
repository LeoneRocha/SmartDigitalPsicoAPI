using SmartDigitalPsico.Domain.ModelEntity.Schedule;

namespace SmartDigitalPsico.Domain.DTO.Schedule
{

    public class ScheduleItemValidationContext
    {
        public ScheduleItem? NewItem { get; set; }
        public ScheduleItem[] ExistingItems { get; set; } = [];
        public long MedicalId { get; set; }
    }
}
