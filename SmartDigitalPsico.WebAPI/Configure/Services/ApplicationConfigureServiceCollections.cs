using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Service.Configure;

namespace SmartDigitalPsico.WebAPI.Configure.Services
{
    public static class ApplicationConfigureServiceCollections
    {
        private static IConfiguration? _configuration;

        public static void Configure(IServiceCollection services, IConfiguration configuration, Serilog.Core.Logger _logger)
        {
            _configuration = configuration;

            ApplicationConfigureAppSettings.Configure(services, _configuration);

            var tokenConfigurations = ApplicationConfigureAppSettings.AddAndReturnTokenConfiguration(services, _configuration);

            //For In-Memory Caching
            ApplicationConfigureCaching.Configure(services);

            //Security API
            ApplicationConfigureSecurity.Configure(services, tokenConfigurations);

            //Header
            ApplicationConfigureHeader.Configure(services);

            //CORS
            ApplicationConfigureCors.Configure(services);

            //HyperMediaFilterOptions
            HyperMediaConfigure.AddHyperMedia(services);

            //Documentation
            ApplicationConfigureDocumentation.Configure(services);

            //AutoMapper
            ApplicationConfigureAutoMapper.Configure(services);

            //Dependencies Services
            ApplicationConfigureDependenciesServices.Configure(services, _configuration);

            //ORM API 
            ApplicationConfigureORM.Configure(services, _configuration);

            //Add log 
            ApplicationConfigureLog.Configure(services, _logger);

            //Localization
            ApplicationConfigureLocalization.Configure(services);

            ApplicationConfigureEndpointsApiExplorer.Configure(services);
        }
    }
}