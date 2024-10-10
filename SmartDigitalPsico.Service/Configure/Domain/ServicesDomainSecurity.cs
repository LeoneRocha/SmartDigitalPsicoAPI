using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Security;
using SmartDigitalPsico.Service.Security;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    public static class ServicesDomainSecurity
    {
        public static void AddDependencies(IServiceCollection services)
        { 
            services.AddTransient<ICryptoAdapterFactory, CryptoAdapterFactory>();
            services.AddTransient<ICryptoService, CryptoService>();
        }
    }
}