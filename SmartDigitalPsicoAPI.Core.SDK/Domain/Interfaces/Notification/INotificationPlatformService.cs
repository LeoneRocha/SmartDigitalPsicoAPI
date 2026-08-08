using SmartDigitalPsicoAPI.Core.SDK.Domain.VO;

namespace SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Notification
{
    /// <summary>
    /// Interface (contrato) responsável por INotificationPlatformService.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface INotificationPlatformService
    {
        /// <summary>
        /// Método SendAsync: dispara notificação ou comunicação.
        /// </summary>
        Task SendAsync(DataNotificationTemplateVO template, Dictionary<string, string> tokens); 
    }
}
