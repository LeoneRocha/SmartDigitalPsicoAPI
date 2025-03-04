using SmartDigitalPsico.Service.Configure;
using SmartDigitalPsico.Service.Configure.Domain;

namespace SmartDigitalPsico.WindowsService.Configure
{
    public static class WindowsServiceConfigureServiceCollections
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration, Serilog.Core.Logger _logger)
        {
            ServiceCollectionConfigureAppSettings.Configure(services, configuration);
             
            //For In-Memory Caching
            ServiceCollectionConfigureCaching.Configure(services);
                 
            //AutoMapper
            ServiceCollectionConfigureAutoMapper.Configure(services);

            //Dependencies Services
            ServiceCollectionConfigureServicesDomain.Configure(services, configuration);

            //ORM API 
            ServiceCollectionConfigureOrm.Configure(services, configuration);

            //Add log 
            ServiceCollectionConfigureLog.Configure(services, _logger); 
        }
    }
}