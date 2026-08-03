namespace SmartDigitalPsico.Domain.Helpers.Schedule
{
    /// <summary>
    /// Classe responsável por SchedulePeriodHelper.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
    public static class SchedulePeriodHelper
    {
        /// <summary>
        /// Método static: executa a operação static.
        /// </summary>
        public static (DateTime Start, DateTime End) GetMonthRange(int year, int month)
        {
            var start = new DateTime(year, month, 1, 0, 0, 0, DateTimeKind.Utc);
            var end = start.AddMonths(1);
            return (start, end);
        }

        /// <summary>
        /// Método static: executa a operação static.
        /// </summary>
        public static (DateTime Start, DateTime End) NormalizeRange(DateTime? start, DateTime? end, int year, int month)
        {
            if (start.HasValue && end.HasValue)
                return (start.Value, end.Value);

            return GetMonthRange(year, month);
        }

        /// <summary>
        /// Método CapOccurrences: executa a operação CapOccurrences.
        /// </summary>
        public static int CapOccurrences(int requested, int max = 500)
            => Math.Clamp(requested <= 0 ? max : requested, 1, max);
    }
}
