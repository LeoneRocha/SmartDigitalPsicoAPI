using SmartCoreHub.Core.SDK.Common.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.ApiExplorer;

/// <summary>
/// DI EndpointsApiExplorer — exclusivo SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.DependenciesCollection.Extensions.CoreServiceCollectionExtensions",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "AddCoreEndpointsApiExplorer SDP-only.")]
public static class EndpointsApiExplorerServiceCollectionExtensions
{
    public static IServiceCollection AddCoreEndpointsApiExplorer(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        return services;
    }
}
