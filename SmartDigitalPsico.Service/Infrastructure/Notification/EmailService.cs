using SmartDigitalPsico.Domain.DTO.SMTP;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.Infrastructure.Smtp;

namespace SmartDigitalPsico.Service.Infrastructure.Notification
{
    /// <summary>
    /// Classe responsável por EmailService.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
    public class EmailService : IEmailService
    {
        private readonly EmailContext _emailContext;

        /// <summary>
        /// Método EmailService: executa a operação EmailService.
        /// </summary>
        public EmailService(EmailContext emailContext)
        {
            _emailContext = emailContext;
        }

        /// <summary>
        /// Método SendAsync: dispara notificação ou comunicação.
        /// </summary>
        public async Task SendAsync(
            DataNotificationTemplateVO template, Dictionary<string, string> tokens)
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
