using SmartDigitalPsico.Core.SDK.Domain.Constants;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    /// <summary>
    /// Classe responsável por GenderMockData.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class GenderMockData
    {
        /// <summary>
        /// Método GetMock: consulta e retorna dados.
        /// </summary>
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
