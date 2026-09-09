using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.DTO.SMTP;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure.Notification;

/// <summary>
/// Casca EmailService — orquestra template → SMTP via EmailContext SDP.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Email.EmailService",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca EmailService; tokens via EmailHelper; envio via EmailContext SDP.")]
public class EmailService : IEmailService
{
    private readonly EmailContext _emailContext;

    public EmailService(EmailContext emailContext)
    {
        _emailContext = emailContext ?? throw new ArgumentNullException(nameof(emailContext));
    }

    public async Task SendAsync(DataNotificationTemplateVO template, Dictionary<string, string> tokens)
    {
        ArgumentNullException.ThrowIfNull(template);
        var body = EmailHelper.ReplaceTokens(template.Body, tokens);
        var emailMessage = new EmailMessageDto
        {
            Subject = template.Subject,
            Message = body,
            ToEmails = template.ToEmails ?? []
        };
        await _emailContext.SendEmailAsync(EEmailStrategyType.Smtp, emailMessage).ConfigureAwait(false);
    }
}
