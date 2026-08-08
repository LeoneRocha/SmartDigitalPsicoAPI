using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Service.Configure.ApiExplorer;

namespace SmartDigitalPsico.Service.Configure
{
    /// <summary>
    /// Wrapper host: delega EndpointsApiExplorer para o Core.SDK.
    /// </summary>
    public static class ServiceCollectionConfigureEndpointsApiExplorer
    {
        public static void Configure(IServiceCollection services)
            => services.AddCoreEndpointsApiExplorer();
    }
}
