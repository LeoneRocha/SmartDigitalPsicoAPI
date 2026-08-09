namespace SmartDigitalPsico.Domain.Helpers.Schedule
{
    /// <summary>
    /// Classe responsável por ScheduleOverlapHelper.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
    public static class ScheduleOverlapHelper
    {
        /// <summary>
        /// Método Overlaps: executa a operação Overlaps.
        /// </summary>
        public static bool Overlaps(DateTime startA, DateTime endA, DateTime startB, DateTime endB)
            => startA < endB && endA > startB;

        /// <summary>
        /// Método Overlaps: executa a operação Overlaps.
        /// </summary>
        public static bool Overlaps(DateTime startA, DateTime? endA, DateTime startB, DateTime? endB)
        {
            var aEnd = endA ?? startA;
            var bEnd = endB ?? startB;
            return Overlaps(startA, aEnd, startB, bEnd);
        }

        /// <summary>
        /// Método IsAdjacentOnly: executa a operação IsAdjacentOnly.
        /// </summary>
        public static bool IsAdjacentOnly(DateTime startA, DateTime endA, DateTime startB, DateTime endB)
            => endA == startB || endB == startA;
    }
}
