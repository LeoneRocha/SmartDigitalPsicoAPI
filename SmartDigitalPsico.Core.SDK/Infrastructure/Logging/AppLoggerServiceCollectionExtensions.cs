using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;

namespace SmartDigitalPsico.Core.SDK.Infrastructure.Logging
{
    /// <summary>
    /// Extensões DI para registrar IAppLogger sobre Serilog.
    /// </summary>
    public static class AppLoggerServiceCollectionExtensions
    {
        /// <summary>
        /// Registra <see cref="IAppLogger"/> como singleton adaptando o <see cref="Serilog.ILogger"/> já presente no container
        /// (ou o <paramref name="logger"/> informado).
        /// </summary>
        public static IServiceCollection AddAppLogger(this IServiceCollection services, Serilog.ILogger? logger = null)
        {
            if (logger is not null)
            {
                services.AddSingleton(logger);
            }

            services.AddSingleton<IAppLogger>(sp =>
            {
                var serilog = logger ?? sp.GetRequiredService<Serilog.ILogger>();
                return new SerilogAppLoggerAdapter(serilog);
            });

            return services;
        }
    }
}
