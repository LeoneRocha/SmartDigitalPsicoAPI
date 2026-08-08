using SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.SMTP;

namespace SmartDigitalPsico.Domain.Interfaces.Smtp
{
    /// <summary>
    /// Interface (contrato) responsável por IEmailStrategy.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface IEmailStrategy
    {
        /// <summary>
        /// Método SendEmailAsync: dispara notificação ou comunicação.
        /// </summary>
        Task SendEmailAsync(EmailMessageDto emailMessage);
    }
}
