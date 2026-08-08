using SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.SMTP;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Smtp;
using SmartDigitalPsicoAPI.Core.SDK.Domain.VO;
using SmartDigitalPsicoAPI.Core.SDK.Service.Infrastructure.Smtp;

namespace SmartDigitalPsico.Service.Infrastructure.Notification
{
    /// <summary>
    /// Classe responsável por EmailService.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
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
            var body = SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.EmailHelper.ReplaceTokens(template.Body, tokens);
            var emailMessage = new EmailMessageDto
            {
                Subject = template.Subject,
                Message = body,
                ToEmails = template.ToEmails
            };
            // Lógica para envio de email
            var type = SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns.EEmailStrategyType.Smtp;

            await _emailContext.SendEmailAsync(type, emailMessage);
        }
    }
}
