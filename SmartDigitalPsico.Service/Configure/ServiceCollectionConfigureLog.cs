using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Infrastructure.Logging;

namespace SmartDigitalPsico.Service.Configure
{
    /// <summary>
    /// Classe responsável por ServiceCollectionConfigureLog.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: registra serviços no container e configura o pipeline.
    /// </summary>
    public static class ServiceCollectionConfigureLog
    {
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public static void Configure(IServiceCollection services, Serilog.Core.Logger _logger)
        {
            addLog(services, _logger);
        }

        private static void addLog(IServiceCollection services, Serilog.Core.Logger _logger)
        {
            services.AddLogging();
            // Serilog permanece no container para UseSerilog / host; app code usa IAppLogger.
            services.AddAppLogger(_logger);
        }
    }
}
