using SmartDigitalPsico.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Domain.VO.SMTP;
using System.Net;
using System.Net.Mail;

namespace SmartDigitalPsico.Service.Infrastructure.Smtp
{
    public class SmtpEmailStrategy : IEmailStrategy
    {
        private readonly ISmtpSettingsVO _smtpSettings;

        public SmtpEmailStrategy(ISmtpSettingsVO smtpSettings)
        {
            _smtpSettings = smtpSettings;
        }

        public async Task SendEmailAsync(EmailMessageVO emailMessage)
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

            using (var client = new SmtpClient(_smtpSettings.Server, _smtpSettings.Port))
            {
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(_smtpSettings.Username, _smtpSettings.Password);
                client.EnableSsl = true;
                await client.SendMailAsync(mailMessage);
            };
        }
    }
}