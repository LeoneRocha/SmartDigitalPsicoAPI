namespace SmartDigitalPsico.Domain.Helpers.Schedule
{
    public static class SchedulePeriodHelper
    {
        public static (DateTime Start, DateTime End) GetMonthRange(int year, int month)
        {
            var start = new DateTime(year, month, 1, 0, 0, 0, DateTimeKind.Utc);
            var end = start.AddMonths(1);
            return (start, end);
        }

        public static (DateTime Start, DateTime End) NormalizeRange(DateTime? start, DateTime? end, int year, int month)
        {
            if (start.HasValue && end.HasValue)
                return (start.Value, end.Value);

            return GetMonthRange(year, month);
        }

        public static int CapOccurrences(int requested, int max = 500)
            => Math.Clamp(requested <= 0 ? max : requested, 1, max);
    }
}
