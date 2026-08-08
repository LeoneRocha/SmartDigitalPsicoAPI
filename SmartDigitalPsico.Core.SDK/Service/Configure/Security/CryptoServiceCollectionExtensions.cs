using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security;
using SmartDigitalPsico.Core.SDK.Domain.Security;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Security
{
    public static class CryptoServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreCrypto(this IServiceCollection services)
        {
            services.AddTransient<ICryptoAdapterFactory, CryptoAdapterFactory>();
            services.AddTransient<ICryptoService, CryptoService>();
            return services;
        }
    }
}
