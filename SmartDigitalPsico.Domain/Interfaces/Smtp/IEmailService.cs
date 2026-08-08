using SmartDigitalPsico.Domain.Interfaces.Notification;

namespace SmartDigitalPsico.Domain.Interfaces.Smtp
{
    /// <summary>
    /// Interface (contrato) responsável por IEmailService.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface IEmailService : INotificationPlatformService
    { 
    }
}
