﻿using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    public static class ApplicationConfigSettingMockData  
    { 
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