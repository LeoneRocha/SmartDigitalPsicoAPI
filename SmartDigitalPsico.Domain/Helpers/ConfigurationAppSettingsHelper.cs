using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Constants;

namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Classe responsável por ConfigurationAppSettingsHelper.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
    public static class ConfigurationAppSettingsHelper
    {
        #region GENERIC
        /// <summary>
        /// Método GetSectionApp: consulta e retorna dados.
        /// </summary>
        public static IConfiguration GetSectionApp(IConfiguration? configuration, string sectionName)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration), AppConfigConstants.ConfigurationConfigurationNotBeNull);
            }
            return configuration.GetSection(sectionName);
        }

        /// <summary>
        /// Método GetConnectionStringApp: consulta e retorna dados.
        /// </summary>
        public static string GetConnectionStringApp(IConfiguration? configuration, string connectionName)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration), AppConfigConstants.ConfigurationConfigurationNotBeNull);
            }
            return configuration.GetConnectionString(connectionName) ?? string.Empty;
        }

        /// <summary>
        /// Método GetValueStringConfiguration: consulta e retorna dados.
        /// </summary>
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

        /// <summary>
        /// Método GetCacheConfiguration: consulta e retorna dados.
        /// </summary>
        public static IConfiguration GetCacheConfiguration(IConfiguration? configuration)
        {
            return GetSectionApp(configuration, "CacheConfiguration");
        }
        /// <summary>
        /// Método GetAuthConfiguration: consulta e retorna dados.
        /// </summary>
        public static IConfiguration GetAuthConfiguration(IConfiguration? configuration)
        {
            return GetSectionApp(configuration, "AuthConfiguration");
        }

        /// <summary>
        /// Método GetTokenConfigurations: consulta e retorna dados.
        /// </summary>
        public static IConfiguration GetTokenConfigurations(IConfiguration? configuration)
        {
            return GetSectionApp(configuration, "TokenConfigurations");
        }

        /// <summary>
        /// Método GetConnectionStringMySQL: consulta e retorna dados.
        /// </summary>
        public static string GetConnectionStringMySQL(IConfiguration? configuration)
        {
            return GetConnectionStringApp(configuration, "SmartDigitalPsicoDBConnectionMySQL");
        }

        /// <summary>
        /// Método GetConnectionStringSQL: consulta e retorna dados.
        /// </summary>
        public static string GetConnectionStringSQL(IConfiguration? configuration)
        {
            return GetConnectionStringApp(configuration, "SmartDigitalPsicoDBConnectionSQLServer");
        }

        /// <summary>
        /// Método GetDataBaseConfigurations: consulta e retorna dados.
        /// </summary>
        public static IConfiguration GetDataBaseConfigurations(IConfiguration? configuration)
        {
            return GetSectionApp(configuration, "DataBaseConfigurations");
        }

        /// <summary>
        /// Método GetAppSettingsResourcesTemp: consulta e retorna dados.
        /// </summary>
        public static string GetAppSettingsResourcesTemp(IConfiguration? configuration)
        {
            return GetValueStringConfiguration(configuration, "AppSettings:ResourcesTemp");
        }

        /// <summary>
        /// Método GetIResiliencePolicyConfig: consulta e retorna dados.
        /// </summary>
        public static IConfiguration GetIResiliencePolicyConfig(IConfiguration configuration)
        {
            return GetSectionApp(configuration, "ResiliencePolicyConfig");
        }

        /// <summary>
        /// Método GetLocationSaveFileConfigurationVO: consulta e retorna dados.
        /// </summary>
        public static IConfiguration GetLocationSaveFileConfigurationVO(IConfiguration configuration)
        {
            return GetSectionApp(configuration, "LocationSaveFileConfigurationVO");
        }
        /// <summary>
        /// Método GetSmtpSettings: consulta e retorna dados.
        /// </summary>
        public static IConfiguration GetSmtpSettings(IConfiguration configuration)
        {
            return GetSectionApp(configuration, "SmtpSettings");
        }

        /// <summary>
        /// Método GetAllowedFileExtensions: consulta e retorna dados.
        /// </summary>
        public static string[] GetAllowedFileExtensions(IConfiguration configuration)
        {
            return configuration.GetSection("AppSettings:AllowedFileExtensions").Get<string[]>() ?? [];
        }
        /// <summary>
        /// Método GetAllowedContentTypes: consulta e retorna dados.
        /// </summary>
        public static string[] GetAllowedContentTypes(IConfiguration configuration)
        {
            return configuration.GetSection("AppSettings:AllowedContentTypes").Get<string[]>() ?? [];
        }
        /// <summary>
        /// Método GetMaxFileSizeMegabytes: consulta e retorna dados.
        /// </summary>
        public static long GetMaxFileSizeMegabytes(IConfiguration configuration)
        {
            return configuration.GetSection("AppSettings:MaxFileSizeMegabytes").Get<long>();
        } 

        /// <summary>
        /// Método GetStorageServicesAzureStorageConnectionString: consulta e retorna dados.
        /// </summary>
        public static string GetStorageServicesAzureStorageConnectionString(IConfiguration configuration)
        {
            return configuration.GetSection("StorageServices:AzureStorage")["ConnectionString"] ?? string.Empty;
        }

        /// <summary>
        /// Método GetStorageServicesAzureStorageDaysExpiresBlobSas: consulta e retorna dados.
        /// </summary>
        public static string GetStorageServicesAzureStorageDaysExpiresBlobSas(IConfiguration configuration)
        {
            return configuration.GetSection("StorageServices:AzureStorage")["DaysExpiresBlobSas"] ?? string.Empty;
        }
         
        /// <summary>
        /// Método GetSecuritySettingsAesSettingAesKey: consulta e retorna dados.
        /// </summary>
        public static string GetSecuritySettingsAesSettingAesKey(IConfiguration configuration)
        {
            return configuration.GetSection("SecuritySettings:AesSettings")["AesKey"] ?? string.Empty;
        }
        /// <summary>
        /// Método GetSecuritySettingsAesSettingAesIv: consulta e retorna dados.
        /// </summary>
        public static string GetSecuritySettingsAesSettingAesIv(IConfiguration configuration)
        {
            return configuration.GetSection("SecuritySettings:AesSettings")["AesIv"] ?? string.Empty;
        }
    }
} 
