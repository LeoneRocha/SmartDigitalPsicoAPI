using SmartDigitalPsico.Core.SDK.Domain.Constants;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Context.Mock
{
    /// <summary>
    /// Classe responsável por OfficeMockData.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class OfficeMockData
    {
        /// <summary>
        /// Método GetMock: consulta e retorna dados.
        /// </summary>
        public static Office[] GetMock()
        {
            return [
               new Office { Id = 1, CreatedDate = MockSeedDates.SeedUtc, Enable = true, Description = "Psicólogo", Language = CultureConstants.LanguagePTBR },
               new Office { Id = 2, CreatedDate = MockSeedDates.SeedUtc, Enable = true, Description = "Psicóloga", Language = CultureConstants.LanguagePTBR },
               new Office { Id = 3, CreatedDate = MockSeedDates.SeedUtc, Enable = true, Description = "Clínico", Language = CultureConstants.LanguagePTBR },
            ];
        }
    }
}
