using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Service.Configure;

namespace SmartDigitalPsico.WebAPI.Configure
{
    public static class WebApplicationConfigureServiceCollections
    {
        private static IConfiguration? _configuration;

        public static void Configure(IServiceCollection services, IConfiguration configuration, Serilog.Core.Logger _logger)
        {
            _configuration = configuration;

            ServiceCollectionConfigureAppSettings.Configure(services, _configuration);

            var tokenConfigurations = ServiceCollectionConfigureAppSettings.AddAndReturnTokenConfiguration(services, _configuration);

            //For In-Memory Caching
            ServiceCollectionConfigureCaching.Configure(services);

            //Security API
            ServiceCollectionConfigureSecurity.Configure(services, tokenConfigurations);

            //Header
            ServiceCollectionConfigureHeader.Configure(services);

            //CORS
            ServiceCollectionConfigureCors.Configure(services);

            //HyperMediaFilterOptions
            HyperMediaConfigure.AddHyperMedia(services);

            //Documentation
            ServiceCollectionConfigureDocumentation.Configure(services);

            //AutoMapper
            ServiceCollectionConfigureAutoMapper.Configure(services);

            //Dependencies Services
            ServiceCollectionConfigureServicesDomain.Configure(services, _configuration);

            //ORM API 
            ServiceCollectionConfigureORM.Configure(services, _configuration);

            //Add log 
            ServiceCollectionConfigureLog.Configure(services, _logger);

            //Localization
            ServiceCollectionConfigureLocalization.Configure(services);

            //Endpoints Api Explorer
            ServiceCollectionConfigureEndpointsApiExplorer.Configure(services);
        }
    }
}