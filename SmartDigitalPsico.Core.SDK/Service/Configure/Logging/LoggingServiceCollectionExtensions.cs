using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Infrastructure.Logging;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Logging
{
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
}
