namespace SmartDigitalPsico.Domain.Helpers.Schedule
{
    /// <summary>
    /// Classe responsável por TimeSlotWindow.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
    public sealed class TimeSlotWindow
    {
        public DateTime Date { get; init; }
        public TimeSpan StartWorkingTime { get; init; }
        public TimeSpan EndWorkingTime { get; init; }
        public TimeSpan Interval { get; init; }
    }

    /// <summary>
    /// Classe responsável por GeneratedTimeSlot.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
    public sealed class GeneratedTimeSlot
    {
        public DateTime StartTime { get; init; }
        public DateTime EndTime { get; init; }
        public bool IsAvailable { get; init; }
        public bool IsPast { get; init; }
    }

    /// <summary>
    /// Classe responsável por TimeSlotGenerator.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
    public static class TimeSlotGenerator
    {
        /// <summary>
        /// Legacy-parity: emit slots for the full calendar day (00:00 → +1 day).
        /// Availability is gated by working hours and busy intervals.
        /// </summary>
        public static List<GeneratedTimeSlot> Generate(
            TimeSlotWindow window,
            IReadOnlyList<(DateTime Start, DateTime End)> busyIntervals,
            DateTime nowUtc)
        {
            var result = new List<GeneratedTimeSlot>();
            if (window.Interval <= TimeSpan.Zero) return result;

            var dayStart = window.Date.Date;
            var dayEnd = dayStart.AddDays(1);
            var workingStart = dayStart + window.StartWorkingTime;
            var workingEnd = dayStart + window.EndWorkingTime;

            var sortedBusy = busyIntervals
                .Where(b => ScheduleOverlapHelper.Overlaps(b.Start, b.End, dayStart, dayEnd))
                .OrderBy(b => b.Start)
                .ToList();

            for (var cursor = dayStart; cursor < dayEnd; cursor += window.Interval)
            {
                var slotEnd = cursor + window.Interval;
                var isBusy = sortedBusy.Any(b => ScheduleOverlapHelper.Overlaps(cursor, slotEnd, b.Start, b.End));
                var isWithinWorkingHours = cursor >= workingStart && slotEnd <= workingEnd;
                result.Add(new GeneratedTimeSlot
                {
                    StartTime = cursor,
                    EndTime = slotEnd,
                    IsAvailable = !isBusy && isWithinWorkingHours,
                    IsPast = cursor <= nowUtc
                });
            }

            return result;
        }
    }
}
