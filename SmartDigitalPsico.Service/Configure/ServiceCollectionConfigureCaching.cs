using Microsoft.Extensions.DependencyInjection;

namespace SmartDigitalPsico.Service.Configure
{
    public static class ServiceCollectionConfigureCaching
    {
        public static void Configure(IServiceCollection services)
        {
            addCaching(services);
        }
        private static void addCaching(IServiceCollection services)
        {
            services.AddMemoryCache();
        }
    }
}
