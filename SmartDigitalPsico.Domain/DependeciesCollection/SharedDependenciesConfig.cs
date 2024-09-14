using AutoMapper;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;

namespace SmartDigitalPsico.Domain.DependeciesCollection
{
    public class SharedDependenciesConfig : ISharedDependenciesConfig
    {
        public IMapper Mapper { get; }
        public Serilog.ILogger Logger { get; }
        public IResiliencePolicyConfig PolicyConfig { get; }

        public IConfiguration Configuration { get; }

        public SharedDependenciesConfig(
            IMapper mapper,
            Serilog.ILogger logger,
            IResiliencePolicyConfig policyConfig,
           IConfiguration configuration)
        {
            Mapper = mapper;
            Logger = logger;
            PolicyConfig = policyConfig;
            Configuration = configuration;
        }
    }
}
