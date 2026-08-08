using Microsoft.Extensions.DependencyInjection;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Caching
{
    public static class CachingServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreCaching(this IServiceCollection services)
        {
            services.AddMemoryCache();
            return services;
        }
    }
}
