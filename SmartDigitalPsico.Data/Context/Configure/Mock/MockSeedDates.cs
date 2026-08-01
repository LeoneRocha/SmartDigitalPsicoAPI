namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    /// <summary>
    /// Datas estáticas para HasData/seeds. Nunca use DateTime.Now/UtcNow aqui — causa drift em migrations.
    /// </summary>
    public static class MockSeedDates
    {
        public static readonly DateTime SeedUtc = new(2026, 8, 1, 12, 0, 0, DateTimeKind.Utc);

        /// <summary>Ano fixo para feriados (Leaves).</summary>
        public const int SeedYear = 2026;
    }
}
