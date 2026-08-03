namespace SmartDigitalPsico.Domain.Helpers.Schedule
{
    /// <summary>
    /// Opções de paralelismo CPU para o módulo Schedule.
    /// MaxDegreeOfParallelism e limiares derivados de Environment.ProcessorCount.
    /// Regra: nunca usar dentro de acesso EF/DbContext — DB fica antes ou depois do Parallel.
    /// </summary>
    public static class ScheduleParallel
    {
        /// <summary>
        /// Número de threads lógicas disponíveis no host.
        /// </summary>
        public static int CpuCount { get; } = Math.Max(1, Environment.ProcessorCount);

        /// <summary>
        /// Usa o máximo de threads lógicas disponíveis (CpuCount).
        /// Destinado apenas a trabalho CPU-bound — nunca a acesso EF/DbContext.
        /// </summary>
        public static ParallelOptions MaxAvailableThreads { get; } = new()
        {
            MaxDegreeOfParallelism = CpuCount
        };

        /// <summary>
        /// Limiar dinâmico para paralelizar geração de slots: igual ao nº de CPUs.
        /// Abaixo disso o overhead de scheduling supera o ganho.
        /// </summary>
        public static int SlotParallelThreshold => CpuCount;

        /// <summary>
        /// Limiar dinâmico para paralelizar mapeamento de intervalos → ScheduleCalendarItem (BuildItems).
        /// Igual ao CpuCount — alinhado ao limiar de slots.
        /// </summary>
        public static int MapParallelThreshold => CpuCount;
    }
}
