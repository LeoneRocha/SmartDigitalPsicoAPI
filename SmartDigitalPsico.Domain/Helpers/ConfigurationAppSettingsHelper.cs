using Microsoft.Extensions.Configuration;

namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Helper de appsettings: genéricos/seções Core delegam ao SCH (NuGet 20260910.6.0);
    /// seções de produto permanecem aqui.
    /// </summary>
    public static class ConfigurationAppSettingsHelper
    {
        #region GENERIC
        public static IConfiguration GetSectionApp(IConfiguration? configuration, string sectionName)
            => ConfigurationSectionHelper.GetSectionApp(configuration, sectionName);

        public static string GetConnectionStringApp(IConfiguration? configuration, string connectionName)
            => ConfigurationSectionHelper.GetConnectionStringApp(configuration, connectionName);

        public static string GetValueStringConfiguration(IConfiguration? configuration, string configurationName)
            => ConfigurationSectionHelper.GetValueStringConfiguration(configuration, configurationName);
        #endregion GENERIC

        public static IConfiguration GetCacheConfiguration(IConfiguration? configuration)
            => AppSettingsConfigurationHelperSch.GetCacheConfiguration(configuration);

        public static IConfiguration GetAuthConfiguration(IConfiguration? configuration)
            => AppSettingsConfigurationHelperSch.GetAuthConfiguration(configuration);

        public static IConfiguration GetTokenConfigurations(IConfiguration? configuration)
            => AppSettingsConfigurationHelperSch.GetTokenConfigurations(configuration);

        public static string GetConnectionStringMySQL(IConfiguration? configuration)
            => GetConnectionStringApp(configuration, "SmartDigitalPsicoDBConnectionMySQL");

        public static string GetConnectionStringSQL(IConfiguration? configuration)
            => GetConnectionStringApp(configuration, "SmartDigitalPsicoDBConnectionSQLServer");

        public static IConfiguration GetDataBaseConfigurations(IConfiguration? configuration)
            => AppSettingsConfigurationHelperSch.GetDataBaseConfigurations(configuration);

        public static string GetAppSettingsResourcesTemp(IConfiguration? configuration)
            => GetValueStringConfiguration(configuration, "AppSettings:ResourcesTemp");

        public static IConfiguration GetIResiliencePolicyConfig(IConfiguration configuration)
            => AppSettingsConfigurationHelperSch.GetResiliencePolicyConfig(configuration);

        public static IConfiguration GetLocationSaveFileConfigurationVO(IConfiguration configuration)
            => AppSettingsConfigurationHelperSch.GetLocationSaveFileConfiguration(configuration);

        public static IConfiguration GetSmtpSettings(IConfiguration configuration)
            => AppSettingsConfigurationHelperSch.GetSmtpSettings(configuration);

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
