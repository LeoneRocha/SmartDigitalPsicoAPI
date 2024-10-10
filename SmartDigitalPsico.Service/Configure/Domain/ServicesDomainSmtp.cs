using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Service.Infrastructure.Smtp;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    public static class ServicesDomainSmtp
    { 
        public static void AddDependencies(IServiceCollection services)
        { 
            services.AddSingleton<IEmailService, EmailService>();
            services.AddSingleton<IEmailStrategyFactory, EmailStrategyFactory>();
            services.AddSingleton<EmailContext>();
        } 
    }
}