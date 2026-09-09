using SmartDigitalPsico.Core.SDK.Service.Configure.ApiExplorer;
using SmartDigitalPsico.Core.SDK.Service.Configure.AppSettings;
using SmartDigitalPsico.Core.SDK.Service.Configure.Caching;
using SmartDigitalPsico.Core.SDK.Service.Configure.Cors;
using SmartDigitalPsico.Core.SDK.Service.Configure.Documentation;
using SmartDigitalPsico.Core.SDK.Service.Configure.Localization;
using SmartDigitalPsico.Core.SDK.Service.Configure.Logging;
using SmartDigitalPsico.Core.SDK.Service.Configure.Mapping;
using SmartDigitalPsico.Core.SDK.Service.Configure.Mvc;
using SmartDigitalPsico.Core.SDK.Service.Configure.Security;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Mapper;

using SmartDigitalPsico.Service;
using SmartDigitalPsico.Service.DependencyInjection.Orchestrator;
namespace SmartDigitalPsico.WebAPI.Configure
{
    /// <summary>
    /// Startup DI WebAPI — usa aliases <c>AddCore*</c> da casca SDP (SDP-AJUSTE SA.2).
    /// Não chamar SCH <c>CoreServiceCollectionExtensions.AddCore*</c> diretamente (registraria tipos SCH).
    /// Helpers SCH via <c>GlobalUsings.Core.cs</c> (DateHelper, DirectoryHelper, …).
    /// </summary>
    public static class WebApplicationConfigureServiceCollections
    {
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public static void Configure(IServiceCollection services, IConfiguration configuration, Serilog.Core.Logger _logger)
        {
            services.AddCoreAppSettings(configuration);

            var tokenConfigurations = services.AddAndReturnTokenConfiguration(configuration);

            services.AddCoreCaching();
            services.AddCoreJwtBearer(tokenConfigurations);
            services.AddCoreMvcControllers();
            services.AddCoreCors();

            HyperMediaConfigure.AddHyperMedia(services);

            services.AddCoreSwagger(
                title: "SmartDigitalPsico.WebAPI",
                description: "API REST do Smart Digital Psico para gestão clínica, agenda, pacientes e configurações do sistema.",
                version: LogAppHelper.GetAssemblyVersion());

            services.AddCoreMapping(typeof(AutoMapperProfile));

            ServiceCollectionConfigureServicesDomain.Configure(services, configuration);

            ServiceCollectionConfigureOrm.Configure(services, configuration);

            services.AddCoreLogging(_logger);

            services.AddCoreLocalization();

            services.AddCoreEndpointsApiExplorer();
        }
    }
}
