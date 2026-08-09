using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Infrastructure.Mapping;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Mapping
{
    public static class MappingServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreMapper(this IServiceCollection services, params Assembly[] profileAssemblies)
        {
            services.AddAutoMapper(cfg =>
            {
                if (profileAssemblies is { Length: > 0 })
                {
                    cfg.AddMaps(profileAssemblies);
                }
            });
            services.AddAppMapper();
            return services;
        }

        public static IServiceCollection AddCoreMapper(this IServiceCollection services, Type profileMarkerType)
        {
            ArgumentNullException.ThrowIfNull(profileMarkerType);
            return services.AddCoreMapper(profileMarkerType.Assembly);
        }
    }
}
