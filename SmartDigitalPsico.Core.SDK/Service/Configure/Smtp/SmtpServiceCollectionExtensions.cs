using SmartCoreHub.Core.SDK.Common.Attributes;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure.Notification;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp;

namespace SmartDigitalPsico.Core.SDK.Service.Configure.Smtp;

/// <summary>
/// DI SMTP — registra tipos casca SDP (requer <see cref="ISmtpSettingsDto"/> no host / AppSettings).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.DependenciesCollection.Extensions.CoreServiceCollectionExtensions.AddCoreSmtp",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Alias AddCoreSmtp; registra EmailService/Factory/Context casca SDP.")]
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
