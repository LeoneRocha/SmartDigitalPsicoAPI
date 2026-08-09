using Microsoft.Extensions.DependencyInjection;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.ApiExplorer
{
    public static class EndpointsApiExplorerServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreEndpointsApiExplorer(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            return services;
        }
    }
}
