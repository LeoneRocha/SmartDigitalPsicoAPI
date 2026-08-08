using SmartDigitalPsico.Core.SDK.Domain.Constants;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    /// <summary>
    /// Classe responsável por SpecialtyMockData.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class SpecialtyMockData  
    { 
        /// <summary>
        /// Método GetMock: consulta e retorna dados.
        /// </summary>
        public static Specialty[] GetMock()
        {
            return [
                new Specialty { Id = 1, Enable = true, CreatedDate = MockSeedDates.SeedUtc, Description = "Psicologia Clínica", Language = CultureConstants.LanguagePTBR },
                new Specialty { Id = 2, Enable = true, CreatedDate = MockSeedDates.SeedUtc, Description = "Psicologia Social", Language = CultureConstants.LanguagePTBR },
                new Specialty { Id = 3, Enable = true, CreatedDate = MockSeedDates.SeedUtc, Description = "Psicologia educacional", Language = CultureConstants.LanguagePTBR },
                new Specialty { Id = 4, Enable = true, CreatedDate = MockSeedDates.SeedUtc, Description = "Psicologia Esportiva ", Language = CultureConstants.LanguagePTBR },
                new Specialty { Id = 5, Enable = true, CreatedDate = MockSeedDates.SeedUtc, Description = "Psicologia organizacional", Language = CultureConstants.LanguagePTBR },
                new Specialty { Id = 6, Enable = true, CreatedDate = MockSeedDates.SeedUtc, Description = "Psicologia hospitalar", Language = CultureConstants.LanguagePTBR },
                new Specialty { Id = 7, Enable = true, CreatedDate = MockSeedDates.SeedUtc, Description = "Psicologia do trânsito", Language = CultureConstants.LanguagePTBR }
                ];
        }
    }
}
