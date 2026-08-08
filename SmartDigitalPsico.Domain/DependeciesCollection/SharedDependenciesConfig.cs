using AutoMapper;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Mapping;

using SmartDigitalPsico.Domain.Interfaces.Common;
namespace SmartDigitalPsico.Domain.DependeciesCollection
{
    /// <summary>
    /// Classe responsável por SharedDependenciesConfig.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class SharedDependenciesConfig : ISharedDependenciesConfig
    {
        public IAppMapper Mapper { get; }
        public IAppLogger Logger { get; }
        public SmartDigitalPsico.Core.SDK.Domain.Interfaces.IResiliencePolicyConfig PolicyConfig { get; }

        public IConfiguration Configuration { get; }

        /// <summary>
        /// Método SharedDependenciesConfig: executa a operação SharedDependenciesConfig.
        /// </summary>
        public SharedDependenciesConfig(
            IAppMapper mapper,
            IAppLogger logger,
            SmartDigitalPsico.Core.SDK.Domain.Interfaces.IResiliencePolicyConfig policyConfig,
           IConfiguration configuration)
        {
            Mapper = mapper;
            Logger = logger;
            PolicyConfig = policyConfig;
            Configuration = configuration;
        }
    }
}
