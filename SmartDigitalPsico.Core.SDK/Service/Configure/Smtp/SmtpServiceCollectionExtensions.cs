using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure.Notification;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Smtp
{
    public static class SmtpServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreSmtp(this IServiceCollection services)
        {
            services.AddSingleton<IEmailService, EmailService>();
            services.AddSingleton<IEmailStrategyFactory, EmailStrategyFactory>();
            services.AddSingleton<EmailContext>();
            return services;
        }
    }
}
