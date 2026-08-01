using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    public static class InfoTagMockData
    {
        private static readonly DateTime SeedDate = new(2025, 3, 4, 12, 0, 0, DateTimeKind.Utc);

        public static InfoTag[] GetMock()
        {
            return
            [
                new InfoTag
                {
                    Id = 1,
                    Enable = true,
                    CreatedDate = SeedDate,
                    ModifyDate = SeedDate,
                    LastAccessDate = SeedDate,
                    CreatedUserId = 2,
                    MedicalId = 1,
                    Tag = "Ansiedade"
                },
                new InfoTag
                {
                    Id = 2,
                    Enable = true,
                    CreatedDate = SeedDate,
                    ModifyDate = SeedDate,
                    LastAccessDate = SeedDate,
                    CreatedUserId = 2,
                    MedicalId = 1,
                    Tag = "Depressão"
                },
                new InfoTag
                {
                    Id = 3,
                    Enable = true,
                    CreatedDate = SeedDate,
                    ModifyDate = SeedDate,
                    LastAccessDate = SeedDate,
                    CreatedUserId = 2,
                    MedicalId = 1,
                    Tag = "TDAH"
                }
            ];
        }
    }
}
