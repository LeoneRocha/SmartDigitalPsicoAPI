using SmartCoreHub.Core.SDK.Common.Attributes;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Infrastructure.Logging;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Logging;

/// <summary>
/// DI logging — registra <c>IAppLogger</c> SDP (≠ SCH <c>ISdpAppLogger</c>).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.DependenciesCollection.Extensions.CoreServiceCollectionExtensions.AddCoreLogging",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Alias AddCoreLogging; AddAppLogger → IAppLogger SDP (retenção vs ISdpAppLogger).")]
public static class LoggingServiceCollectionExtensions
{
    public static IServiceCollection AddCoreLogging(
        this IServiceCollection services,
        Serilog.ILogger logger)
    {
        services.AddLogging();
        services.AddAppLogger(logger);
        return services;
    }
}
