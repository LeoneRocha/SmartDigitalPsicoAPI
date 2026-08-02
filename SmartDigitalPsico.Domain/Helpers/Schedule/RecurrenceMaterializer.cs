using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Helpers.Schedule
{
    public sealed class RecurrenceInterval
    {
        public DateTime StartDateTime { get; init; }
        public DateTime EndDateTime { get; init; }
    }

    public sealed class RecurrenceMaterializeRequest
    {
        public DateTime StartDateTime { get; init; }
        public DateTime EndDateTime { get; init; }
        public ERecurrenceCalendarType RecurrenceType { get; init; }
        public DayOfWeek[] RecurrenceDays { get; init; } = [];
        public DateTime? RecurrenceEndDate { get; init; }
        public short? RecurrenceCount { get; init; }
        public int MaxOccurrences { get; init; } = 500;
    }

    public static class RecurrenceMaterializer
    {
        public static List<RecurrenceInterval> Materialize(RecurrenceMaterializeRequest request)
        {
            var duration = request.EndDateTime - request.StartDateTime;
            if (duration < TimeSpan.Zero)
                duration = TimeSpan.Zero;

            if (request.RecurrenceType == ERecurrenceCalendarType.None)
            {
                return
                [
                    new RecurrenceInterval
                    {
                        StartDateTime = request.StartDateTime,
                        EndDateTime = request.EndDateTime
                    }
                ];
            }

            var items = new List<RecurrenceInterval>();
            switch (request.RecurrenceType)
            {
                case ERecurrenceCalendarType.Daily:
                    MaterializeDaily(request, duration, items);
                    break;
                case ERecurrenceCalendarType.Weekly:
                    MaterializeWeekly(request, duration, items);
                    break;
                case ERecurrenceCalendarType.Monthly:
                    MaterializeMonthly(request, duration, items);
                    break;
                case ERecurrenceCalendarType.Yearly:
                    MaterializeYearly(request, duration, items);
                    break;
            }

            return items;
        }

        private static bool ShouldContinue(DateTime current, DateTime? endDate, short? count, int generated, int max)
        {
            if (generated >= max) return false;
            if (count.HasValue && count.Value > 0 && generated >= count.Value) return false;
            if (endDate.HasValue && current.Date > endDate.Value.Date) return false;
            return true;
        }

        private static void MaterializeDaily(RecurrenceMaterializeRequest request, TimeSpan duration, List<RecurrenceInterval> items)
        {
            var current = request.StartDateTime;
            while (ShouldContinue(current, request.RecurrenceEndDate, request.RecurrenceCount, items.Count, request.MaxOccurrences))
            {
                if (request.RecurrenceDays.Length == 0 || request.RecurrenceDays.Contains(current.DayOfWeek))
                {
                    items.Add(new RecurrenceInterval { StartDateTime = current, EndDateTime = current + duration });
                }
                current = current.AddDays(1);
                if (!request.RecurrenceCount.HasValue && !request.RecurrenceEndDate.HasValue)
                    break;
            }
        }

        private static void MaterializeWeekly(RecurrenceMaterializeRequest request, TimeSpan duration, List<RecurrenceInterval> items)
        {
            var days = GetEffectiveRecurrenceDays(request);
            var currentWeek = request.StartDateTime.Date;

            while (ShouldContinue(currentWeek, request.RecurrenceEndDate, request.RecurrenceCount, items.Count, request.MaxOccurrences))
            {
                MaterializeWeeklyOccurrences(request, duration, items, days, currentWeek);
                currentWeek = currentWeek.AddDays(7);
                if (ShouldStopAfterSingleWeek(request, items))
                    break;
            }
        }

        private static DayOfWeek[] GetEffectiveRecurrenceDays(RecurrenceMaterializeRequest request)
            => request.RecurrenceDays.Length > 0 ? request.RecurrenceDays : [request.StartDateTime.DayOfWeek];

        private static bool ShouldStopAfterSingleWeek(RecurrenceMaterializeRequest request, List<RecurrenceInterval> items)
            => !request.RecurrenceCount.HasValue && !request.RecurrenceEndDate.HasValue && items.Count > 0;

        private static void MaterializeWeeklyOccurrences(
            RecurrenceMaterializeRequest request,
            TimeSpan duration,
            List<RecurrenceInterval> items,
            DayOfWeek[] days,
            DateTime currentWeek)
        {
            foreach (var day in days.OrderBy(d => d))
            {
                if (HasReachedOccurrenceLimit(request, items))
                    break;

                TryAddWeeklyInterval(request, duration, items, currentWeek, day);
            }
        }

        private static bool HasReachedOccurrenceLimit(RecurrenceMaterializeRequest request, List<RecurrenceInterval> items)
            => items.Count >= request.MaxOccurrences
               || (request.RecurrenceCount.HasValue && request.RecurrenceCount.Value > 0 && items.Count >= request.RecurrenceCount.Value);

        private static void TryAddWeeklyInterval(
            RecurrenceMaterializeRequest request,
            TimeSpan duration,
            List<RecurrenceInterval> items,
            DateTime currentWeek,
            DayOfWeek day)
        {
            var date = GetNextWeekday(currentWeek, day);
            var start = date.Date + request.StartDateTime.TimeOfDay;
            if (start < request.StartDateTime)
                return;
            if (request.RecurrenceEndDate.HasValue && start.Date > request.RecurrenceEndDate.Value.Date)
                return;

            items.Add(new RecurrenceInterval { StartDateTime = start, EndDateTime = start + duration });
        }

        private static void MaterializeMonthly(RecurrenceMaterializeRequest request, TimeSpan duration, List<RecurrenceInterval> items)
        {
            var current = request.StartDateTime;
            var day = request.StartDateTime.Day;
            while (ShouldContinue(current, request.RecurrenceEndDate, request.RecurrenceCount, items.Count, request.MaxOccurrences))
            {
                if (request.RecurrenceDays.Length == 0 || request.RecurrenceDays.Contains(current.DayOfWeek))
                {
                    items.Add(new RecurrenceInterval { StartDateTime = current, EndDateTime = current + duration });
                }
                current = AddMonthsClamped(current, 1, day);
                if (!request.RecurrenceCount.HasValue && !request.RecurrenceEndDate.HasValue)
                    break;
            }
        }

        private static void MaterializeYearly(RecurrenceMaterializeRequest request, TimeSpan duration, List<RecurrenceInterval> items)
        {
            var current = request.StartDateTime;
            while (ShouldContinue(current, request.RecurrenceEndDate, request.RecurrenceCount, items.Count, request.MaxOccurrences))
            {
                items.Add(new RecurrenceInterval { StartDateTime = current, EndDateTime = current + duration });
                current = current.AddYears(1);
                if (!request.RecurrenceCount.HasValue && !request.RecurrenceEndDate.HasValue)
                    break;
            }
        }

        private static DateTime GetNextWeekday(DateTime start, DayOfWeek day)
        {
            var daysToAdd = ((int)day - (int)start.DayOfWeek + 7) % 7;
            return start.AddDays(daysToAdd);
        }

        private static DateTime AddMonthsClamped(DateTime value, int months, int preferredDay)
        {
            var next = value.AddMonths(months);
            var daysInMonth = DateTime.DaysInMonth(next.Year, next.Month);
            var day = Math.Min(preferredDay, daysInMonth);
            return new DateTime(next.Year, next.Month, day, value.Hour, value.Minute, value.Second, value.Kind);
        }
    }
}
