using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Mapping;

namespace SmartDigitalPsico.Domain.Interfaces.Collection
{
    /// <summary>
    /// Interface (contrato) responsável por ISharedDependenciesConfig.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface ISharedDependenciesConfig
    {
        IAppLogger Logger { get; }
        IAppMapper Mapper { get; }
        SmartDigitalPsico.Core.SDK.Domain.Interfaces.IResiliencePolicyConfig PolicyConfig { get; }

        IConfiguration Configuration { get; }
    }
}
