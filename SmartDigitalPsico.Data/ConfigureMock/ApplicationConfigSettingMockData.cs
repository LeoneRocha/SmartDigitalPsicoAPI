using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.ConfigureMock
{
    public class ApplicationConfigSettingMockData : IEntityTypeConfiguration<ApplicationConfigSetting>
    {
        public void Configure(EntityTypeBuilder<ApplicationConfigSetting> modelBuilder)
        {
            modelBuilder.HasData(GetMock());
        }
        public static ApplicationConfigSetting[] GetMock()
        {
            return [
              new ApplicationConfigSetting {
                  Id = 1,
                  Description = "Default",
                  Language = CultureConstants.LanguagePTBR,
                  CreatedDate = DataHelper.GetDateTimeNow(),
                  ModifyDate = DataHelper.GetDateTimeNow(),
                  LastAccessDate = DataHelper.GetDateTimeNow(),
                  TypeLocationCache = ETypeLocationCache.Memory,
                  TypeLocationSaveFiles = ETypeLocationSaveFiles.DataBase,
                  TypeLocationQueeMessaging = ETypeLocationQueeMessaging.MongoDB,
                  EndPointUrl_Cache = string.Empty,
                  EndPointUrl_StorageFiles = string.Empty,
                  Enable = true
              }
              ];
        }
    }
}