using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Service.Configure.Caching;

namespace SmartDigitalPsico.Service.Configure
{
    /// <summary>
    /// Wrapper host: delega cache em memória para o Core.SDK.
    /// </summary>
    public static class ServiceCollectionConfigureCaching
    {
        public static void Configure(IServiceCollection services)
            => services.AddCoreCaching();
    }
}
