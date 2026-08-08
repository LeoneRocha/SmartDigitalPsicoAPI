using SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.SMTP;

namespace SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Smtp
{
    /// <summary>
    /// Interface (contrato) responsável por IEmailStrategy.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IEmailStrategy
    {
        /// <summary>
        /// Método SendEmailAsync: dispara notificação ou comunicação.
        /// </summary>
        Task SendEmailAsync(EmailMessageDto emailMessage);
    }
}
