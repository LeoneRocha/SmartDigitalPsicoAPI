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
        /// Gera slots do dia (00:00 → +1 day). CPU-only; busy já filtrado em memória.
        /// Onde Parallel: Parallel.For por índice de slot quando allowParallel e slotCount &gt;= SlotParallelThreshold (CpuCount).
        /// Ganho esperado: dia único com muitos slots (ex.: intervalo 5–15 min).
        /// Por que allowParallel=false no grade mensal: GenerateDays já paraleliza por dia — Parallel aninhado oversubscreve o thread pool.
        /// Array indexado (não ConcurrentBag): cada índice i escreve só em result[i], ordem preservada.
        /// </summary>
        public static List<GeneratedTimeSlot> Generate(
            TimeSlotWindow window,
            IReadOnlyList<(DateTime Start, DateTime End)> busyIntervals,
            DateTime nowUtc,
            bool allowParallel = true)
        {
            if (window.Interval <= TimeSpan.Zero)
                return [];

            var dayStart = window.Date.Date;
            var dayEnd = dayStart.AddDays(1);
            var workingStart = dayStart + window.StartWorkingTime;
            var workingEnd = dayStart + window.EndWorkingTime;

            var sortedBusy = busyIntervals
                .Where(b => ScheduleOverlapHelper.Overlaps(b.Start, b.End, dayStart, dayEnd))
                .OrderBy(b => b.Start)
                .ToList();

            var slotCount = (int)((dayEnd - dayStart).Ticks / window.Interval.Ticks);
            if (slotCount <= 0)
                return [];

            var result = new GeneratedTimeSlot[slotCount];

            void FillSlot(int i)
            {
                var cursor = dayStart + TimeSpan.FromTicks(window.Interval.Ticks * i);
                var slotEnd = cursor + window.Interval;
                var isBusy = sortedBusy.Any(b => ScheduleOverlapHelper.Overlaps(cursor, slotEnd, b.Start, b.End));
                var isWithinWorkingHours = cursor >= workingStart && slotEnd <= workingEnd;
                result[i] = new GeneratedTimeSlot
                {
                    StartTime = cursor,
                    EndTime = slotEnd,
                    IsAvailable = !isBusy && isWithinWorkingHours,
                    IsPast = cursor <= nowUtc
                };
            }

            if (allowParallel && slotCount >= ScheduleParallel.SlotParallelThreshold)
            {
                Parallel.For(0, slotCount, ScheduleParallel.MaxAvailableThreads, FillSlot);
            }
            else
            {
                for (var i = 0; i < slotCount; i++)
                    FillSlot(i);
            }

            return result.ToList();
        }
    }
}
