using SmartDigitalPsico.Domain.ModelEntity.Schedule;

namespace SmartDigitalPsico.Domain.DTO.Schedule
{
    public class WeeklyRecurrenceParams
    {
        public required ScheduleItem Template { get; set; }
        public List<ScheduleItem> Items { get; set; } = new List<ScheduleItem>();
        public DateTime? EndDate { get; set; }
        public short? Count { get; set; }
        public DayOfWeek[] Days { get; set; } = [];
    }
    public class RecurrenceContext
    {
        public DateTime CurrentDate { get; set; }
        public int ItemCount { get; set; }
        public TimeSpan Duration { get; set; }
    }


}
