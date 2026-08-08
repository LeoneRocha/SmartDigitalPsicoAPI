using AutoMapper;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;

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
        IMapper Mapper { get; }
        SmartDigitalPsico.Core.SDK.Domain.Interfaces.IResiliencePolicyConfig PolicyConfig { get; }

        IConfiguration Configuration { get; }
    }
}
