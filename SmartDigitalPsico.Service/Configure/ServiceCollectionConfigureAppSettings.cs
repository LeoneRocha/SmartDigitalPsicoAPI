using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.DTO.Security;
using SmartDigitalPsico.Domain.DTO.SMTP;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Domain.Resiliency;

namespace SmartDigitalPsico.Service.Configure
{
    /// <summary>
    /// Classe responsável por ServiceCollectionConfigureAppSettings.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: registra serviços no container e configura o pipeline.
    /// </summary>
    public static class ServiceCollectionConfigureAppSettings
    {
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public static void Configure(IServiceCollection services, IConfiguration _configuration)
        {  
            addSmtpConfig(services, _configuration);
             
            addResiliencePolicies(services, _configuration);
            
            addLocationSaveFileConfiguration(services, _configuration);

            addCacheConfiguration(services, _configuration);    
        }

        private static void addCacheConfiguration(IServiceCollection services, IConfiguration _configuration )
        {
            services.Configure<SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.CacheConfigurationDto>(ConfigurationAppSettingsHelper.GetCacheConfiguration(_configuration));
            services.Configure<SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.AuthConfigurationDto>(ConfigurationAppSettingsHelper.GetAuthConfiguration(_configuration)); 
        }
         
        private static void addSmtpConfig(IServiceCollection services, IConfiguration configuration)
        {
            // Bind the PolicyConfig section of appsettings.json to the PolicyConfig class
            var smtpSettings = new SmartDigitalPsico.Core.SDK.Domain.DTO.SMTP.SmtpSettingsDto();

            var configValue = ConfigurationAppSettingsHelper.GetSmtpSettings(configuration);
            new ConfigureFromConfigurationOptions<SmartDigitalPsico.Core.SDK.Domain.DTO.SMTP.SmtpSettingsDto>(configValue)
             .Configure(smtpSettings);
            // Register the PolicyConfig instance as a singleton
            services.AddSingleton<ISmtpSettingsDto>(smtpSettings);
        }

        /// <summary>
        /// Método AddAndReturnTokenConfiguration: cria ou persiste um novo registro/recurso.
        /// </summary>
        public static SmartDigitalPsico.Core.SDK.Domain.DTO.Security.TokenConfigurationDto AddAndReturnTokenConfiguration(IServiceCollection services, IConfiguration _configuration)
        {  
            var configValue = ConfigurationAppSettingsHelper.GetTokenConfigurations(_configuration);

            var tokenConfigurations = new SmartDigitalPsico.Core.SDK.Domain.DTO.Security.TokenConfigurationDto();

            new ConfigureFromConfigurationOptions<SmartDigitalPsico.Core.SDK.Domain.DTO.Security.TokenConfigurationDto>(configValue)
             .Configure(tokenConfigurations);

            services.AddSingleton<SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security.ITokenConfigurationDto>(tokenConfigurations);
            services.AddSingleton(tokenConfigurations);

            return tokenConfigurations;
        }

        private static void addResiliencePolicies(IServiceCollection services, IConfiguration _configuration)
        {
            // Bind the PolicyConfig section of appsettings.json to the PolicyConfig class
            var policyConfig = new ResiliencePolicyConfig();
            var configValue = ConfigurationAppSettingsHelper.GetIResiliencePolicyConfig(_configuration);
            new ConfigureFromConfigurationOptions<ResiliencePolicyConfig>(configValue)
             .Configure(policyConfig);
            // Register the PolicyConfig instance as a singleton
            services.AddSingleton<SmartDigitalPsico.Core.SDK.Domain.Interfaces.IResiliencePolicyConfig>(policyConfig);
        }

        private static void addLocationSaveFileConfiguration(IServiceCollection services, IConfiguration _configuration)
        {
            var locationSaveFileConfigurationVO = new SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.LocationSaveFileConfigurationDto();
            var configValue = ConfigurationAppSettingsHelper.GetLocationSaveFileConfigurationVO(_configuration);

            new ConfigureFromConfigurationOptions<SmartDigitalPsico.Core.SDK.Domain.DTO.Domains.LocationSaveFileConfigurationDto>(configValue)
             .Configure(locationSaveFileConfigurationVO);
            services.AddSingleton<SmartDigitalPsico.Core.SDK.Domain.Interfaces.ILocationSaveFileConfigurationDto>(locationSaveFileConfigurationVO);
        } 

        /// <summary>
        /// Método AddAndReturnTypeDataBase: cria ou persiste um novo registro/recurso.
        /// </summary>
        public static ETypeDataBase AddAndReturnTypeDataBase(IConfiguration configuration)
        {
            DataBaseConfigurationDto configDB = new DataBaseConfigurationDto();

            new ConfigureFromConfigurationOptions<DataBaseConfigurationDto>(ConfigurationAppSettingsHelper.GetDataBaseConfigurations(configuration))
                .Configure(configDB);


            return configDB.TypeDataBase;
        } 
    }
}
