using Microsoft.Extensions.DependencyInjection;

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
            //Add log 
            addLog(services, _logger);
        }
        private static void addLog(IServiceCollection services, Serilog.Core.Logger _logger)
        {
            services.AddLogging();
            services.AddSingleton<Serilog.ILogger>(sp =>
            {
                return _logger;
            });
        }
    }
}
