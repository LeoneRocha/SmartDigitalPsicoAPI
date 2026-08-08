using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Service.Configure.Cors;

namespace SmartDigitalPsico.Service.Configure
{
    /// <summary>
    /// Wrapper host: delega CORS padrão para o Core.SDK.
    /// </summary>
    public static class ServiceCollectionConfigureCors
    {
        public static void Configure(IServiceCollection services)
            => services.AddCoreCors();
    }
}
