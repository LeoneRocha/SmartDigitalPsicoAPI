using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Domains;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Security;
using SmartDigitalPsico.Core.SDK.Domain.DTO.SMTP;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Core.SDK.Domain.Resiliency;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.AppSettings
{
    public static class AppSettingsServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreAppSettings(this IServiceCollection services, IConfiguration configuration)
        {
            AddSmtpConfig(services, configuration);
            AddResiliencePolicies(services, configuration);
            AddLocationSaveFileConfiguration(services, configuration);
            AddCacheAndAuthConfiguration(services, configuration);
            return services;
        }

        public static TokenConfigurationDto AddAndReturnTokenConfiguration(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var configValue = AppSettingsConfigurationHelper.GetTokenConfigurations(configuration);
            var tokenConfigurations = new TokenConfigurationDto();
            new ConfigureFromConfigurationOptions<TokenConfigurationDto>(configValue)
                .Configure(tokenConfigurations);

            services.AddSingleton<ITokenConfigurationDto>(tokenConfigurations);
            services.AddSingleton(tokenConfigurations);
            return tokenConfigurations;
        }

        public static ETypeDataBase AddAndReturnTypeDataBase(IConfiguration configuration)
        {
            var configDb = new DataBaseConfigurationDto();
            new ConfigureFromConfigurationOptions<DataBaseConfigurationDto>(
                    AppSettingsConfigurationHelper.GetDataBaseConfigurations(configuration))
                .Configure(configDb);
            return configDb.TypeDataBase;
        }

        private static void AddCacheAndAuthConfiguration(IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<CacheConfigurationDto>(AppSettingsConfigurationHelper.GetCacheConfiguration(configuration));
            services.Configure<AuthConfigurationDto>(AppSettingsConfigurationHelper.GetAuthConfiguration(configuration));
        }

        private static void AddSmtpConfig(IServiceCollection services, IConfiguration configuration)
        {
            var smtpSettings = new SmtpSettingsDto();
            var configValue = AppSettingsConfigurationHelper.GetSmtpSettings(configuration);
            new ConfigureFromConfigurationOptions<SmtpSettingsDto>(configValue).Configure(smtpSettings);
            services.AddSingleton<ISmtpSettingsDto>(smtpSettings);
        }

        private static void AddResiliencePolicies(IServiceCollection services, IConfiguration configuration)
        {
            var policyConfig = new ResiliencePolicyConfig();
            var configValue = AppSettingsConfigurationHelper.GetResiliencePolicyConfig(configuration);
            new ConfigureFromConfigurationOptions<ResiliencePolicyConfig>(configValue).Configure(policyConfig);
            services.AddSingleton<IResiliencePolicyConfig>(policyConfig);
        }

        private static void AddLocationSaveFileConfiguration(IServiceCollection services, IConfiguration configuration)
        {
            var locationSaveFileConfiguration = new LocationSaveFileConfigurationDto();
            var configValue = AppSettingsConfigurationHelper.GetLocationSaveFileConfiguration(configuration);
            new ConfigureFromConfigurationOptions<LocationSaveFileConfigurationDto>(configValue)
                .Configure(locationSaveFileConfiguration);
            services.AddSingleton<ILocationSaveFileConfigurationDto>(locationSaveFileConfiguration);
        }
    }
}
