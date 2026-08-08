using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    /// <summary>
    /// Classe responsável por ServicesDomainSmtp.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: registra serviços no container e configura o pipeline.
    /// </summary>
    public static class ServicesDomainSmtp
    {
        /// <summary>
        /// Método AddDependencies: cria ou persiste um novo registro/recurso.
        /// </summary>
        public static void AddDependencies(IServiceCollection services)
        {
            services.AddSingleton<IEmailService, SmartDigitalPsico.Core.SDK.Service.Infrastructure.Notification.EmailService>();
            services.AddSingleton<IEmailStrategyFactory, SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp.EmailStrategyFactory>();
            services.AddSingleton<EmailContext>(); 
        }
    }
}
