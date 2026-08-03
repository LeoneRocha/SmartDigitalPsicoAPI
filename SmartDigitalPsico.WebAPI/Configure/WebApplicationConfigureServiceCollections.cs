using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Service.Configure;
using SmartDigitalPsico.Service.Configure.Domain;

namespace SmartDigitalPsico.WebAPI.Configure
{
    /// <summary>
    /// Classe responsável por WebApplicationConfigureServiceCollections.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: registra serviços no container e configura o pipeline.
    /// </summary>
    public static class WebApplicationConfigureServiceCollections
    {  
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public static void Configure(IServiceCollection services, IConfiguration configuration, Serilog.Core.Logger _logger)
        {  
            ServiceCollectionConfigureAppSettings.Configure(services, configuration);

            var tokenConfigurations = ServiceCollectionConfigureAppSettings.AddAndReturnTokenConfiguration(services, configuration);

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
            ServiceCollectionConfigureServicesDomain.Configure(services, configuration);

            //ORM API 
            ServiceCollectionConfigureOrm.Configure(services, configuration);

            //Add log 
            ServiceCollectionConfigureLog.Configure(services, _logger);

            //Localization
            ServiceCollectionConfigureLocalization.Configure(services);

            //Endpoints Api Explorer
            ServiceCollectionConfigureEndpointsApiExplorer.Configure(services);
        }
    }
}
