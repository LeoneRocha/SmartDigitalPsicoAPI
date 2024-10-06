using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.DTO.Security;
using SmartDigitalPsico.Domain.DTO.SMTP;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Domain.Resiliency;

namespace SmartDigitalPsico.Service.Configure
{
    public static class DependenciesInjectionAppSettings
    {
        public static void AddAppSettings(IServiceCollection services, IConfiguration _configuration)
        {  
            addSmtpConfig(services, _configuration);
             
            addResiliencePolicies(services, _configuration);
            
            addLocationSaveFileConfiguration(services, _configuration);

            addCacheConfiguration(services, _configuration);    
        }

        private static void addCacheConfiguration(IServiceCollection services, IConfiguration _configuration )
        {
            services.Configure<CacheConfigurationDto>(ConfigurationAppSettingsHelper.GetCacheConfiguration(_configuration));
            services.Configure<AuthConfigurationDto>(ConfigurationAppSettingsHelper.GetAuthConfiguration(_configuration)); 
        }
         
        private static void addSmtpConfig(IServiceCollection services, IConfiguration configuration)
        {
            // Bind the PolicyConfig section of appsettings.json to the PolicyConfig class
            var smtpSettings = new SmtpSettingsDto();

            var configValue = ConfigurationAppSettingsHelper.GetSmtpSettings(configuration);
            new ConfigureFromConfigurationOptions<SmtpSettingsDto>(configValue)
             .Configure(smtpSettings);
            // Register the PolicyConfig instance as a singleton
            services.AddSingleton<ISmtpSettingsDto>(smtpSettings);
        }

        public static TokenConfigurationDto AddAndReturnTokenConfiguration(IServiceCollection services, IConfiguration _configuration)
        {  
            var configValue = ConfigurationAppSettingsHelper.GetTokenConfigurations(_configuration);

            var tokenConfigurations = new TokenConfigurationDto();

            new ConfigureFromConfigurationOptions<TokenConfigurationDto>(configValue)
             .Configure(tokenConfigurations);

            services.AddSingleton<ITokenConfigurationDto>(tokenConfigurations);
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
            services.AddSingleton<IResiliencePolicyConfig>(policyConfig);
        }

        private static void addLocationSaveFileConfiguration(IServiceCollection services, IConfiguration _configuration)
        {
            var locationSaveFileConfigurationVO = new LocationSaveFileConfigurationDto();
            var configValue = ConfigurationAppSettingsHelper.GetLocationSaveFileConfigurationVO(_configuration);

            new ConfigureFromConfigurationOptions<LocationSaveFileConfigurationDto>(configValue)
             .Configure(locationSaveFileConfigurationVO);
            // Register the PolicyConfig instance as a singleton
            services.AddSingleton<ILocationSaveFileConfigurationDto>(locationSaveFileConfigurationVO);
        }



    }
}