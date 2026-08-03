using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Helpers.Schedule
{
    /// <summary>
    /// Classe responsável por RecurrenceInterval.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
    public sealed class RecurrenceInterval
    {
        public DateTime StartDateTime { get; init; }
        public DateTime EndDateTime { get; init; }
    }

    /// <summary>
    /// Classe responsável por RecurrenceMaterializeRequest.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
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

    /// <summary>
    /// Classe responsável por RecurrenceMaterializer.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
    public static class RecurrenceMaterializer
    {
        /// <summary>
        /// Materializa ocorrências. Sem DB.
        /// Onde Parallel: Daily/Weekly com EndDate ou Count — Parallel.For + bags indexados + merge ordenado.
        /// Ganho esperado: séries longas (dezenas/centenas de ocorrências).
        /// Por que Monthly/Yearly sequenciais: N típico baixo; predicado depende de items.Count no while.
        /// Por que unbounded sequencial: early-break de 1 ocorrência; Parallel no while compartilhado não é seguro.
        /// </summary>
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

        /// <summary>
        /// Daily: se os dias são enumeráveis (EndDate/Count), Parallel.For + merge ordenado.
        /// Ganho esperado: séries diárias longas (ex.: Count=90 / EndDate meses à frente).
        /// Sem bound → while sequencial (early-break de 1 dia).
        /// </summary>
        private static void MaterializeDaily(RecurrenceMaterializeRequest request, TimeSpan duration, List<RecurrenceInterval> items)
        {
            var dayStarts = TryEnumerateDayStarts(request);
            if (dayStarts is { Length: > 0 })
            {
                MaterializeDailyParallel(request, duration, items, dayStarts);
                return;
            }

            // Fallback sequencial: sem EndDate/Count — early-break; Parallel no while não é seguro.
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

        /// <summary>
        /// Onde Parallel: um índice por dia civil; bag opcional por índice (null = dia filtrado).
        /// Merge sequencial aplica Count/MaxOccurrences — fora do Parallel.
        /// Array indexado (não ConcurrentBag): preserva ordem cronológica no merge.
        /// </summary>
        private static void MaterializeDailyParallel(
            RecurrenceMaterializeRequest request,
            TimeSpan duration,
            List<RecurrenceInterval> items,
            DateTime[] dayStarts)
        {
            var perDay = new RecurrenceInterval?[dayStarts.Length];
            Parallel.For(0, dayStarts.Length, ScheduleParallel.MaxAvailableThreads, i =>
            {
                var current = dayStarts[i];
                if (request.RecurrenceEndDate.HasValue && current.Date > request.RecurrenceEndDate.Value.Date)
                    return;
                if (request.RecurrenceDays.Length > 0 && !request.RecurrenceDays.Contains(current.DayOfWeek))
                    return;

                perDay[i] = new RecurrenceInterval
                {
                    StartDateTime = current,
                    EndDateTime = current + duration
                };
            });

            foreach (var interval in perDay)
            {
                if (interval == null)
                    continue;
                if (HasReachedOccurrenceLimit(request, items))
                    return;
                items.Add(interval);
            }
        }

        /// <summary>
        /// Enumera dias civis quando EndDate ou Count permite bound previsível.
        /// Retorna null se Parallel não é seguro (sem limite → early-break de 1 dia).
        /// </summary>
        private static DateTime[]? TryEnumerateDayStarts(RecurrenceMaterializeRequest request)
        {
            if (!request.RecurrenceCount.HasValue && !request.RecurrenceEndDate.HasValue)
                return null;

            var starts = new List<DateTime>();
            var current = request.StartDateTime;
            var maxIterations = request.MaxOccurrences;

            if (request.RecurrenceCount is > 0)
            {
                // Com filtro de dias da semana, pior caso: ~7/matching dias civis por ocorrência.
                var matchingPerWeek = request.RecurrenceDays.Length == 0
                    ? 7
                    : Math.Max(1, request.RecurrenceDays.Length);
                maxIterations = Math.Min(
                    request.MaxOccurrences * 7,
                    ((request.RecurrenceCount.Value + matchingPerWeek - 1) / matchingPerWeek) * 7 + 7);
            }
            else if (request.RecurrenceEndDate.HasValue)
            {
                maxIterations = Math.Min(
                    request.MaxOccurrences * 7,
                    Math.Max(1, (int)(request.RecurrenceEndDate.Value.Date - request.StartDateTime.Date).TotalDays + 1));
            }

            for (var i = 0; i < maxIterations; i++)
            {
                if (request.RecurrenceEndDate.HasValue && current.Date > request.RecurrenceEndDate.Value.Date)
                    break;
                starts.Add(current);
                current = current.AddDays(1);
            }

            return starts.Count > 0 ? starts.ToArray() : null;
        }

        /// <summary>
        /// Weekly: se as semanas são enumeráveis (EndDate/Count), processa em paralelo independente da quantidade
        /// (1..N semanas) com MaxAvailableThreads e merge ordenado. Sem bound → while sequencial (early-break).
        /// </summary>
        private static void MaterializeWeekly(RecurrenceMaterializeRequest request, TimeSpan duration, List<RecurrenceInterval> items)
        {
            var days = GetEffectiveRecurrenceDays(request);
            var weekStarts = TryEnumerateWeekStarts(request, days.Length);

            // Independente de quantas semanas: se deu para enumerar, paraleliza.
            if (weekStarts is { Length: > 0 })
            {
                MaterializeWeeklyParallel(request, duration, items, days, weekStarts);
                return;
            }

            // Fallback sequencial: sem EndDate/Count — early-break de 1 semana; Parallel no while não é seguro.
            var currentWeek = request.StartDateTime.Date;
            while (ShouldContinue(currentWeek, request.RecurrenceEndDate, request.RecurrenceCount, items.Count, request.MaxOccurrences))
            {
                MaterializeWeeklyOccurrences(request, duration, items, days, currentWeek);
                currentWeek = currentWeek.AddDays(7);
                if (ShouldStopAfterSingleWeek(request, items))
                    break;
            }
        }

        /// <summary>
        /// Onde Parallel: Parallel.For por semana; bags em perWeek[i]; merge ordenado fora.
        /// Ganho esperado: séries semanais com EndDate/Count.
        /// Array indexado (não ConcurrentBag): merge cronológico sem sort extra.
        /// </summary>
        private static void MaterializeWeeklyParallel(
            RecurrenceMaterializeRequest request,
            TimeSpan duration,
            List<RecurrenceInterval> items,
            DayOfWeek[] days,
            DateTime[] weekStarts)
        {
            var perWeek = new List<RecurrenceInterval>[weekStarts.Length];
            Parallel.For(0, weekStarts.Length, ScheduleParallel.MaxAvailableThreads, i =>
            {
                var bag = new List<RecurrenceInterval>(days.Length);
                CollectWeeklyOccurrences(request, duration, bag, days, weekStarts[i]);
                perWeek[i] = bag;
            });

            // Merge ordenado (por semana) aplicando limites — fora do Parallel.
            foreach (var weekItems in perWeek)
            {
                if (weekItems == null) continue;
                foreach (var interval in weekItems)
                {
                    if (HasReachedOccurrenceLimit(request, items))
                        return;
                    items.Add(interval);
                }
            }
        }

        /// <summary>
        /// Enumera inícios de semana quando EndDate ou Count permite bound previsível.
        /// Retorna null se Parallel não é seguro/útil (sem limite → early-break de 1 semana).
        /// </summary>
        private static DateTime[]? TryEnumerateWeekStarts(RecurrenceMaterializeRequest request, int daysPerWeek)
        {
            if (!request.RecurrenceCount.HasValue && !request.RecurrenceEndDate.HasValue)
                return null;

            var starts = new List<DateTime>();
            var currentWeek = request.StartDateTime.Date;
            var maxWeeks = request.MaxOccurrences;

            if (request.RecurrenceCount is > 0)
            {
                var perWeek = Math.Max(1, daysPerWeek);
                maxWeeks = Math.Min(maxWeeks, ((request.RecurrenceCount.Value + perWeek - 1) / perWeek) + 1);
            }

            for (var i = 0; i < maxWeeks; i++)
            {
                if (request.RecurrenceEndDate.HasValue && currentWeek.Date > request.RecurrenceEndDate.Value.Date)
                    break;
                starts.Add(currentWeek);
                currentWeek = currentWeek.AddDays(7);
            }

            return starts.Count > 0 ? starts.ToArray() : null;
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

        /// <summary>
        /// Coleta ocorrências da semana sem checar limite global (aplicado no merge).
        /// days.Length tipicamente &lt;= 7 — sem Parallel interno (overhead).
        /// </summary>
        private static void CollectWeeklyOccurrences(
            RecurrenceMaterializeRequest request,
            TimeSpan duration,
            List<RecurrenceInterval> bag,
            DayOfWeek[] days,
            DateTime currentWeek)
        {
            foreach (var day in days.OrderBy(d => d))
                TryAddWeeklyInterval(request, duration, bag, currentWeek, day);
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

        /// <summary>
        /// Monthly sequencial. Sem Parallel: N típico pequeno (meses); while usa items.Count no predicado.
        /// </summary>
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

        /// <summary>
        /// Yearly sequencial. Sem Parallel: N típico muito pequeno (anos); predicado usa items.Count.
        /// </summary>
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
