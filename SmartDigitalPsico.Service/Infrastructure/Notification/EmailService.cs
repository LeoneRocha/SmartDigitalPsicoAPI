using SmartDigitalPsico.Domain.DTO.SMTP;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.Infrastructure.Smtp;

namespace SmartDigitalPsico.Service.Infrastructure.Notification
{
    public class EmailService : IEmailService, INotificationService
    {
        private readonly EmailContext _emailContext;

        public EmailService(EmailContext emailContext)
        {
            _emailContext = emailContext;
        }

        public async Task SendAsync(
            NotificationTemplate template, Dictionary<string, string> tokens)
        {
            var body = EmailHelper.ReplaceTokens(template.Body, tokens);
            var emailMessage = new EmailMessageDto
            {
                Subject = template.Subject,
                Message = body,
                ToEmails = template.ToEmails
            };
            // Lógica para envio de email
            var type = EEmailStrategyType.Smtp;

            await _emailContext.SendEmailAsync(type, emailMessage);
        }
    }
}