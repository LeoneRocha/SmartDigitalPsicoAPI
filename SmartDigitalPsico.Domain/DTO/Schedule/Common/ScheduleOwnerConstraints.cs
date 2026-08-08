namespace SmartDigitalPsico.Domain.DTO.Schedule.Common
{
    /// <summary>
    /// Generic owner working-profile for Core grade/availability (no Medical coupling).
    /// </summary>
    public sealed class ScheduleOwnerConstraints
    {
        public DayOfWeek[] WorkingDays { get; init; } = [];
        public TimeSpan StartWorkingTime { get; init; }
        public TimeSpan EndWorkingTime { get; init; }
        public int IntervalMinutes { get; init; }
        public string DisplayName { get; init; } = string.Empty;
    }
}
