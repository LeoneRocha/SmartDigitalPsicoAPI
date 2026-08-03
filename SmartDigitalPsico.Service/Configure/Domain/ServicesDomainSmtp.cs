using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Service.Infrastructure.Notification;
using SmartDigitalPsico.Service.Infrastructure.Smtp;

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
            services.AddSingleton<IEmailService, EmailService>();
            services.AddSingleton<IEmailStrategyFactory, EmailStrategyFactory>();
            services.AddSingleton<EmailContext>(); 
        }
    }
}
