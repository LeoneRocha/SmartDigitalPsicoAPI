using AutoMapper;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace SmartDigitalPsico.Domain.Interfaces.Collection
{
    public interface ISharedDependenciesConfig
    {  
        ILogger Logger { get; }
        IMapper Mapper { get; }
        IResiliencePolicyConfig PolicyConfig { get; }

        IConfiguration Configuration { get; }
    }
}