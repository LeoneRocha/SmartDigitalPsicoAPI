using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Service.Configure.Security;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    /// <summary>
    /// Wrapper host: crypto Core.SDK.
    /// </summary>
    public static class ServicesDomainSecurity
    {
        public static void AddDependencies(IServiceCollection services)
            => services.AddCoreCrypto();
    }
}
