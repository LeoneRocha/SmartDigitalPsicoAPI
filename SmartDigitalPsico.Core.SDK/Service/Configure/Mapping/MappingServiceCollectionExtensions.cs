using SmartCoreHub.Core.SDK.Common.Attributes;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Infrastructure.Mapping;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Mapping;

/// <summary>
/// DI AutoMapper + <c>IAppMapper</c> SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.DependenciesCollection.Extensions.CoreServiceCollectionExtensions.AddCoreMapping",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Alias AddCoreMapper/AddCoreMapping; IAppMapper SDP.")]
public static class MappingServiceCollectionExtensions
{
    public static IServiceCollection AddCoreMapping(this IServiceCollection services, params Assembly[] profileAssemblies)
        => AddCoreMapper(services, profileAssemblies);

    public static IServiceCollection AddCoreMapping(this IServiceCollection services, Type profileMarkerType)
        => AddCoreMapper(services, profileMarkerType);

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
