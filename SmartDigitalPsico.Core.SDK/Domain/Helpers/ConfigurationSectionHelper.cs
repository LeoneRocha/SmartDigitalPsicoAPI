using Microsoft.Extensions.Configuration;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers
{
    /// <summary>
    /// Helpers genéricos de leitura de IConfiguration (sem nomes de seção de produto).
    /// </summary>
    public static class ConfigurationSectionHelper
    {
        public static IConfiguration GetSectionApp(IConfiguration? configuration, string sectionName)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration), "Configuration cannot be null.");
            }
            return configuration.GetSection(sectionName);
        }

        public static string GetConnectionStringApp(IConfiguration? configuration, string connectionName)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration), "Configuration cannot be null.");
            }
            return configuration.GetConnectionString(connectionName) ?? string.Empty;
        }

        public static string GetValueStringConfiguration(IConfiguration? configuration, string configurationName)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration), "Configuration cannot be null.");
            }
            return configuration[configurationName] ?? string.Empty;
        }
    }
}
