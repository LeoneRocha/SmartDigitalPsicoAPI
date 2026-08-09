using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Core.SDK.Domain.DTO.SMTP;
using System.Net;
using System.Net.Mail;

namespace SmartDigitalPsico.Core.SDK.Service.Infrastructure.Smtp
{
    /// <summary>
    /// Classe responsável por SmtpEmailStrategy.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
    public class SmtpEmailStrategy : IEmailStrategy
    {
        private readonly ISmtpSettingsDto _smtpSettings;

        /// <summary>
        /// Método SmtpEmailStrategy: executa a operação SmtpEmailStrategy.
        /// </summary>
        public SmtpEmailStrategy(ISmtpSettingsDto smtpSettings)
        {
            _smtpSettings = smtpSettings;
        }

        /// <summary>
        /// Método SendEmailAsync: dispara notificação ou comunicação.
        /// </summary>
        public async Task SendEmailAsync(EmailMessageDto emailMessage)
        {
            var mailMessage = new MailMessage
            {
                Subject = emailMessage.Subject,
                Body = emailMessage.Message,
                IsBodyHtml = true,
                From = new MailAddress(_smtpSettings.SenderEmail, _smtpSettings.SenderName)
            };

            foreach (var toEmail in emailMessage.ToEmails)
            {
                mailMessage.To.Add(new MailAddress(toEmail));
            }

            using var client = new SmtpClient(_smtpSettings.Server, _smtpSettings.Port)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_smtpSettings.Username, _smtpSettings.Password),
                EnableSsl = true
            };
            await client.SendMailAsync(mailMessage);
        }
    }
}
