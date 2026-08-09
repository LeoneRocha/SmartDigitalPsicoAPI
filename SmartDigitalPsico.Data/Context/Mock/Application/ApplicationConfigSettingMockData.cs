using SmartDigitalPsico.Core.SDK.Domain.Constants;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Context.Mock
{
    /// <summary>
    /// Classe responsável por ApplicationConfigSettingMockData.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class ApplicationConfigSettingMockData
    {
        /// <summary>
        /// Método GetMock: consulta e retorna dados.
        /// </summary>
        public static ApplicationConfigSetting[] GetMock()
        {
            return [
              new ApplicationConfigSetting {
                  Id = 1,
                  Description = "Default",
                  Language = CultureConstants.LanguagePTBR,
                  CreatedDate = MockSeedDates.SeedUtc,
                  ModifyDate = MockSeedDates.SeedUtc,
                  LastAccessDate = MockSeedDates.SeedUtc,
                  TypeLocationCache = SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationCache.Memory,
                  TypeLocationSaveFiles = SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles.DataBase,
                  TypeLocationQueeMessaging = ETypeLocationQueeMessaging.MongoDB,
                  EndPointUrl_Cache = string.Empty,
                  EndPointUrl_StorageFiles = string.Empty,
                  Enable = true,
                  UrlRootManager = string.Empty,
              }
              ];
        }
    }
}
