using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Domain.DTO.Security;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Service.Configure.AppSettings;

namespace SmartDigitalPsico.Service.Configure
{
    /// <summary>
    /// Wrapper host: delega binding de appsettings genéricos para o Core.SDK.
    /// </summary>
    public static class ServiceCollectionConfigureAppSettings
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
            => services.AddCoreAppSettings(configuration);

        public static TokenConfigurationDto AddAndReturnTokenConfiguration(
            IServiceCollection services,
            IConfiguration configuration)
            => services.AddAndReturnTokenConfiguration(configuration);

        public static ETypeDataBase AddAndReturnTypeDataBase(IConfiguration configuration)
            => AppSettingsServiceCollectionExtensions.AddAndReturnTypeDataBase(configuration);
    }
}
