using Microsoft.Extensions.DependencyInjection;

namespace SmartDigitalPsico.Service.Configure
{
    public static class ServiceCollectionConfigureEndpointsApiExplorer
    {
        public static void Configure(IServiceCollection services)
        { 
            services.AddEndpointsApiExplorer();
        } 
    }
}