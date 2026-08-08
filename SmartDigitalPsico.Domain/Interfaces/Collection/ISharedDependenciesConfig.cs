using AutoMapper;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace SmartDigitalPsico.Domain.Interfaces.Collection
{
    /// <summary>
    /// Interface (contrato) responsável por ISharedDependenciesConfig.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface ISharedDependenciesConfig
    {  
        ILogger Logger { get; }
        IMapper Mapper { get; }
        SmartDigitalPsico.Core.SDK.Domain.Interfaces.IResiliencePolicyConfig PolicyConfig { get; }

        IConfiguration Configuration { get; }
    }
}
