using Microsoft.Extensions.Configuration;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers
{
    /// <summary>
    /// Seções padrão de appsettings reutilizáveis entre hosts API.
    /// </summary>
    public static class AppSettingsConfigurationHelper
    {
        public static IConfiguration GetCacheConfiguration(IConfiguration? configuration)
            => ConfigurationSectionHelper.GetSectionApp(configuration, "CacheConfiguration");

        public static IConfiguration GetAuthConfiguration(IConfiguration? configuration)
            => ConfigurationSectionHelper.GetSectionApp(configuration, "AuthConfiguration");

        public static IConfiguration GetTokenConfigurations(IConfiguration? configuration)
            => ConfigurationSectionHelper.GetSectionApp(configuration, "TokenConfigurations");

        public static IConfiguration GetDataBaseConfigurations(IConfiguration? configuration)
            => ConfigurationSectionHelper.GetSectionApp(configuration, "DataBaseConfigurations");

        public static IConfiguration GetResiliencePolicyConfig(IConfiguration configuration)
            => ConfigurationSectionHelper.GetSectionApp(configuration, "ResiliencePolicyConfig");

        public static IConfiguration GetLocationSaveFileConfiguration(IConfiguration configuration)
            => ConfigurationSectionHelper.GetSectionApp(configuration, "LocationSaveFileConfigurationVO");

        public static IConfiguration GetSmtpSettings(IConfiguration configuration)
            => ConfigurationSectionHelper.GetSectionApp(configuration, "SmtpSettings");
    }
}
