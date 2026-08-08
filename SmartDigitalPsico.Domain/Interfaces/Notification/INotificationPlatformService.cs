using SmartDigitalPsicoAPI.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Notification
{
    /// <summary>
    /// Interface (contrato) responsável por INotificationPlatformService.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface INotificationPlatformService
    {
        /// <summary>
        /// Método SendAsync: dispara notificação ou comunicação.
        /// </summary>
        Task SendAsync(DataNotificationTemplateVO template, Dictionary<string, string> tokens); 
    }
}
