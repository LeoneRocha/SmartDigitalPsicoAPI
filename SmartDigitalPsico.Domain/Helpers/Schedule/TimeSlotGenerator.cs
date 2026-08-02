namespace SmartDigitalPsico.Domain.Helpers.Schedule
{
    public sealed class TimeSlotWindow
    {
        public DateTime Date { get; init; }
        public TimeSpan StartWorkingTime { get; init; }
        public TimeSpan EndWorkingTime { get; init; }
        public TimeSpan Interval { get; init; }
    }

    public sealed class GeneratedTimeSlot
    {
        public DateTime StartTime { get; init; }
        public DateTime EndTime { get; init; }
        public bool IsAvailable { get; init; }
        public bool IsPast { get; init; }
    }

    public static class TimeSlotGenerator
    {
        public static List<GeneratedTimeSlot> Generate(
            TimeSlotWindow window,
            IReadOnlyList<(DateTime Start, DateTime End)> busyIntervals,
            DateTime nowUtc)
        {
            var result = new List<GeneratedTimeSlot>();
            if (window.Interval <= TimeSpan.Zero) return result;

            var dayStart = window.Date.Date + window.StartWorkingTime;
            var dayEnd = window.Date.Date + window.EndWorkingTime;
            if (dayEnd <= dayStart) return result;

            var sortedBusy = busyIntervals
                .Where(b => ScheduleOverlapHelper.Overlaps(b.Start, b.End, dayStart, dayEnd))
                .OrderBy(b => b.Start)
                .ToList();

            for (var cursor = dayStart; cursor + window.Interval <= dayEnd; cursor += window.Interval)
            {
                var slotEnd = cursor + window.Interval;
                var isBusy = sortedBusy.Any(b => ScheduleOverlapHelper.Overlaps(cursor, slotEnd, b.Start, b.End));
                result.Add(new GeneratedTimeSlot
                {
                    StartTime = cursor,
                    EndTime = slotEnd,
                    IsAvailable = !isBusy,
                    IsPast = slotEnd <= nowUtc
                });
            }

            return result;
        }
    }
}
