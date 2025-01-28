using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    public static class SpecialtyMockData  
    { 
        public static Specialty[] GetMock()
        {
            return [
                new Specialty { Id = 1, Enable = true, CreatedDate = DataHelper.GetDateTimeNowFromUtc(), Description = "Psicologia Clínica", Language = CultureConstants.LanguagePTBR },
                new Specialty { Id = 2, Enable = true, CreatedDate = DataHelper.GetDateTimeNowFromUtc(), Description = "Psicologia Social", Language = CultureConstants.LanguagePTBR },
                new Specialty { Id = 3, Enable = true, CreatedDate = DataHelper.GetDateTimeNowFromUtc(), Description = "Psicologia educacional", Language = CultureConstants.LanguagePTBR },
                new Specialty { Id = 4, Enable = true, CreatedDate = DataHelper.GetDateTimeNowFromUtc(), Description = "Psicologia Esportiva ", Language = CultureConstants.LanguagePTBR },
                new Specialty { Id = 5, Enable = true, CreatedDate = DataHelper.GetDateTimeNowFromUtc(), Description = "Psicologia organizacional", Language = CultureConstants.LanguagePTBR },
                new Specialty { Id = 6, Enable = true, CreatedDate = DataHelper.GetDateTimeNowFromUtc(), Description = "Psicologia hospitalar", Language = CultureConstants.LanguagePTBR },
                new Specialty { Id = 7, Enable = true, CreatedDate = DataHelper.GetDateTimeNowFromUtc(), Description = "Psicologia do trânsito", Language = CultureConstants.LanguagePTBR }
                ];
        }
    }
}