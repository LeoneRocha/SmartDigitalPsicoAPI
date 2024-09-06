using SmartDigitalPsico.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Domain.VO.SMTP;
using System.Net;
using System.Net.Mail;

namespace SmartDigitalPsico.Service.Infrastructure.Smtp
{ 
    public class SmtpEmailStrategy : IEmailStrategy
    {
        private readonly SmtpSettingsVO _smtpSettings;

        public SmtpEmailStrategy(SmtpSettingsVO smtpSettings)
        {
            _smtpSettings = smtpSettings;
        }

        public async Task SendEmailAsync(EmailMessageVO emailMessage)
        {
            var mailMessage = new MailMessage
            {
                From = new MailAddress(_smtpSettings.SenderEmail, _smtpSettings.SenderName),
                Subject = emailMessage.Subject,
                Body = emailMessage.Message,
                IsBodyHtml = true
            };

            foreach (var toEmail in emailMessage.ToEmails)
            {
                mailMessage.To.Add(new MailAddress(toEmail));
            }

            using var client = new SmtpClient(_smtpSettings.Server, _smtpSettings.Port)
            {
                Credentials = new NetworkCredential(_smtpSettings.Username, _smtpSettings.Password),
                EnableSsl = true
            };

            await client.SendMailAsync(mailMessage);
        }
    }
} 