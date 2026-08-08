using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Notification
{
    /// <summary>
    /// Interface (contrato) responsável por ISendNotificationService.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface ISendNotificationService
    {
        /// <summary>
        /// Método SendNotificationAsync: dispara notificação ou comunicação.
        /// </summary>
        Task SendNotificationAsync(DataNotificationTemplateVO template, ENotificationServiceType serviceType, Dictionary<string, string> tokens);

    }
}
