using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    public static class OfficeMockData  
    { 
        public static Office[] GetMock()
        {
            return [
               new Office { Id = 1, CreatedDate = DataHelper.GetDateTimeNowFromUtc(), Enable = true, Description = "Psicólogo", Language = CultureConstants.LanguagePTBR },
               new Office { Id = 2, CreatedDate = DataHelper.GetDateTimeNowFromUtc(), Enable = true, Description = "Psicóloga", Language = CultureConstants.LanguagePTBR },
               new Office { Id = 3, CreatedDate = DataHelper.GetDateTimeNowFromUtc(), Enable = true, Description = "Clínico", Language = CultureConstants.LanguagePTBR },
            ];
        }
    }
}