using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Constants;

namespace SmartDigitalPsico.Domain.Helpers
{
    public static class ConfigurationAppSettingsHelper
    {
        #region GENERIC
        public static IConfiguration GetSectionApp(IConfiguration? configuration, string sectionName)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration), AppConfigConstants.ConfigurationConfigurationNotBeNull);
            }
            return configuration.GetSection(sectionName);
        }

        public static string GetConnectionStringApp(IConfiguration? configuration, string connectionName)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration), AppConfigConstants.ConfigurationConfigurationNotBeNull);
            }
            return configuration.GetConnectionString(connectionName) ?? string.Empty;
        }

        public static string GetValueStringConfiguration(IConfiguration? configuration, string configurationName)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration), AppConfigConstants.ConfigurationConfigurationNotBeNull);
            }
            string appsettingsValue = configuration[configurationName] ?? string.Empty;

            return appsettingsValue;
        }


        #endregion GENERIC

        public static IConfiguration GetCacheConfiguration(IConfiguration? configuration)
        {
            return GetSectionApp(configuration, "CacheConfiguration");
        }
        public static IConfiguration GetAuthConfiguration(IConfiguration? configuration)
        {
            return GetSectionApp(configuration, "AuthConfiguration");
        }

        public static IConfiguration GetTokenConfigurations(IConfiguration? configuration)
        {
            return GetSectionApp(configuration, "TokenConfigurations");
        }

        public static string GetConnectionStringMySQL(IConfiguration? configuration)
        {
            return GetConnectionStringApp(configuration, "SmartDigitalPsicoDBConnectionMySQL");
        }

        public static string GetConnectionStringSQL(IConfiguration? configuration)
        {
            return GetConnectionStringApp(configuration, "SmartDigitalPsicoDBConnectionSQLServer");
        }

        public static IConfiguration GetDataBaseConfigurations(IConfiguration? configuration)
        {
            return GetSectionApp(configuration, "DataBaseConfigurations");
        }

        public static string GetAppSettingsResourcesTemp(IConfiguration? configuration)
        { 
            return GetValueStringConfiguration(configuration, "AppSettings:ResourcesTemp");
        }
    }
}
