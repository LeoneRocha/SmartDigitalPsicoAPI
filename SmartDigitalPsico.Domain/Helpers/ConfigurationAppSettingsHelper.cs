using Microsoft.Extensions.Configuration;

namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Helper de appsettings: genéricos delegam ao Core; seções de produto permanecem aqui.
    /// </summary>
    public static class ConfigurationAppSettingsHelper
    {
        #region GENERIC
        public static IConfiguration GetSectionApp(IConfiguration? configuration, string sectionName)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.ConfigurationSectionHelper.GetSectionApp(configuration, sectionName);

        public static string GetConnectionStringApp(IConfiguration? configuration, string connectionName)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.ConfigurationSectionHelper.GetConnectionStringApp(configuration, connectionName);

        public static string GetValueStringConfiguration(IConfiguration? configuration, string configurationName)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.ConfigurationSectionHelper.GetValueStringConfiguration(configuration, configurationName);
        #endregion GENERIC

        public static IConfiguration GetCacheConfiguration(IConfiguration? configuration)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.AppSettingsConfigurationHelper.GetCacheConfiguration(configuration);

        public static IConfiguration GetAuthConfiguration(IConfiguration? configuration)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.AppSettingsConfigurationHelper.GetAuthConfiguration(configuration);

        public static IConfiguration GetTokenConfigurations(IConfiguration? configuration)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.AppSettingsConfigurationHelper.GetTokenConfigurations(configuration);

        public static string GetConnectionStringMySQL(IConfiguration? configuration)
            => GetConnectionStringApp(configuration, "SmartDigitalPsicoDBConnectionMySQL");

        public static string GetConnectionStringSQL(IConfiguration? configuration)
            => GetConnectionStringApp(configuration, "SmartDigitalPsicoDBConnectionSQLServer");

        public static IConfiguration GetDataBaseConfigurations(IConfiguration? configuration)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.AppSettingsConfigurationHelper.GetDataBaseConfigurations(configuration);

        public static string GetAppSettingsResourcesTemp(IConfiguration? configuration)
            => GetValueStringConfiguration(configuration, "AppSettings:ResourcesTemp");

        public static IConfiguration GetIResiliencePolicyConfig(IConfiguration configuration)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.AppSettingsConfigurationHelper.GetResiliencePolicyConfig(configuration);

        public static IConfiguration GetLocationSaveFileConfigurationVO(IConfiguration configuration)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.AppSettingsConfigurationHelper.GetLocationSaveFileConfiguration(configuration);

        public static IConfiguration GetSmtpSettings(IConfiguration configuration)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.AppSettingsConfigurationHelper.GetSmtpSettings(configuration);

        public static string[] GetAllowedFileExtensions(IConfiguration configuration)
            => configuration.GetSection("AppSettings:AllowedFileExtensions").Get<string[]>() ?? [];

        public static string[] GetAllowedContentTypes(IConfiguration configuration)
            => configuration.GetSection("AppSettings:AllowedContentTypes").Get<string[]>() ?? [];

        public static long GetMaxFileSizeMegabytes(IConfiguration configuration)
            => configuration.GetSection("AppSettings:MaxFileSizeMegabytes").Get<long>();

        public static string GetStorageServicesAzureStorageConnectionString(IConfiguration configuration)
            => configuration.GetSection("StorageServices:AzureStorage")["ConnectionString"] ?? string.Empty;

        public static string GetStorageServicesAzureStorageDaysExpiresBlobSas(IConfiguration configuration)
            => configuration.GetSection("StorageServices:AzureStorage")["DaysExpiresBlobSas"] ?? string.Empty;

        public static string GetSecuritySettingsAesSettingAesKey(IConfiguration configuration)
            => configuration.GetSection("SecuritySettings:AesSettings")["AesKey"] ?? string.Empty;

        public static string GetSecuritySettingsAesSettingAesIv(IConfiguration configuration)
            => configuration.GetSection("SecuritySettings:AesSettings")["AesIv"] ?? string.Empty;
    }
}
