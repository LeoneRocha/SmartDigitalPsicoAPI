using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Service.Configure.Logging;

namespace SmartDigitalPsico.Service.Configure
{
    /// <summary>
    /// Wrapper host: delega logging + IAppLogger para o Core.SDK.
    /// </summary>
    public static class ServiceCollectionConfigureLog
    {
        public static void Configure(IServiceCollection services, Serilog.Core.Logger logger)
            => services.AddCoreLogging(logger);
    }
}
