using SmartCoreHub.Core.SDK.Common.Attributes;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using SchLogger = SmartCoreHub.Core.SDK.Domain.Interfaces.Common.IAppLogger;

namespace SmartDigitalPsico.Core.SDK.Infrastructure.Logging
{
    /// <summary>
    /// Extensões DI para registrar IAppLogger SDP e o canônico SCH sobre o mesmo adapter.
    /// </summary>
    [SdkWrappedSource(
        targetType: "SmartCoreHub.Core.SDK.Infrastructure.Logging.AppLoggerServiceCollectionExtensions.AddAppLogger",
        targetPackage: "SmartCoreHub.Core.SDK",
        description: "AJ.2: AddAppLogger registra IAppLogger SDP + SCH (mesmo SerilogAppLoggerAdapter).")]
    public static class AppLoggerServiceCollectionExtensions
    {
        /// <summary>
        /// Registra <see cref="IAppLogger"/> SDP e <see cref="SchLogger"/> canônico como o mesmo singleton.
        /// </summary>
        public static IServiceCollection AddAppLogger(this IServiceCollection services, Serilog.ILogger? logger = null)
        {
            if (logger is not null)
            {
                services.AddSingleton(logger);
            }

            services.AddSingleton(sp =>
            {
                var serilog = logger ?? sp.GetRequiredService<Serilog.ILogger>();
                return new SerilogAppLoggerAdapter(serilog);
            });
            services.AddSingleton<IAppLogger>(sp => sp.GetRequiredService<SerilogAppLoggerAdapter>());
            services.AddSingleton<SchLogger>(sp => sp.GetRequiredService<SerilogAppLoggerAdapter>());

            return services;
        }
    }
}
