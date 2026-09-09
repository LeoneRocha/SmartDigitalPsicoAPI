using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.DTO.SMTP;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp;

/// <summary>
/// Casca SMTP strategy — herda SCH; expõe IEmailStrategy SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Email.SmtpEmailStrategy",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando SmtpEmailStrategy; bridge IEmailStrategy SDP.")]
public class SmtpEmailStrategy : SmartCoreHub.Core.SDK.Service.Email.SmtpEmailStrategy, IEmailStrategy
{
    public SmtpEmailStrategy(ISmtpSettingsDto smtpSettings) : base(smtpSettings)
    {
    }

    Task IEmailStrategy.SendEmailAsync(EmailMessageDto emailMessage)
        => base.SendEmailAsync(emailMessage);
}
