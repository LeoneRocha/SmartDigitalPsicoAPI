using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    public static class GenderMockData  
    { 
        public static Gender[] GetMock()
        {
            return [
                new Gender {
                    Id = 1, Enable = true, CreatedDate = MockSeedDates.SeedUtc, Description = "Masculino", Language = CultureConstants.LanguagePTBR
                },
                new Gender {
                    Id = 2, Enable = true, CreatedDate = MockSeedDates.SeedUtc, Description = "Feminino", Language = CultureConstants.LanguagePTBR
                }
            ];
        }
    }
}