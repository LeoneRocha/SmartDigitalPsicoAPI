using SmartDigitalPsico.Core.SDK.Service.Configure.AppSettings;
using SmartDigitalPsico.Core.SDK.Service.Configure.Caching;
using SmartDigitalPsico.Core.SDK.Service.Configure.Logging;
using SmartDigitalPsico.Core.SDK.Service.Configure.Mapping;
using SmartDigitalPsico.Domain.Mapper;

using SmartDigitalPsico.Service;
using SmartDigitalPsico.Service.DependencyInjection.Orchestrator;
namespace SmartDigitalPsico.WindowsService.Configure
{
    /// <summary>
    /// Startup DI WindowsService — aliases AddCore* casca SDP (SCH-aligned).
    /// </summary>
    public static class WindowsServiceConfigureServiceCollections
    {
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public static void Configure(IServiceCollection services, IConfiguration configuration, Serilog.Core.Logger _logger)
        {
            services.AddCoreAppSettings(configuration);
            services.AddCoreCaching();
            services.AddCoreMapping(typeof(AutoMapperProfile));

            ServiceCollectionConfigureServicesDomain.Configure(services, configuration);

            ServiceCollectionConfigureOrm.Configure(services, configuration);

            services.AddCoreLogging(_logger);
        }
    }
}
