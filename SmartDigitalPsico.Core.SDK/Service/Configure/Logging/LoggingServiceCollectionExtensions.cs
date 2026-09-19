using SmartCoreHub.Core.SDK.Common.Attributes;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Infrastructure.Logging;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Logging;

/// <summary>
/// DI logging — registra IAppLogger SDP e o canônico SCH (mesmo SerilogAppLoggerAdapter).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.DependenciesCollection.Extensions.CoreServiceCollectionExtensions.AddCoreLogging",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Alias AddCoreLogging; AddAppLogger → IAppLogger SDP + SCH (AJ.2).")]
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
