namespace SmartDigitalPsico.Domain.Helpers.Schedule
{
    public static class ScheduleOverlapHelper
    {
        public static bool Overlaps(DateTime startA, DateTime endA, DateTime startB, DateTime endB)
            => startA < endB && endA > startB;

        public static bool Overlaps(DateTime startA, DateTime? endA, DateTime startB, DateTime? endB)
        {
            var aEnd = endA ?? startA;
            var bEnd = endB ?? startB;
            return Overlaps(startA, aEnd, startB, bEnd);
        }

        public static bool IsAdjacentOnly(DateTime startA, DateTime endA, DateTime startB, DateTime endB)
            => endA == startB || endB == startA;
    }
}
