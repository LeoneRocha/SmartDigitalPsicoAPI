using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Interfaces.Notification
{
    /// <summary>
    /// Interface (contrato) responsável por INotificationPlatformServiceFactory.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface INotificationPlatformServiceFactory
    {
        /// <summary>
        /// Método GetService: consulta e retorna dados.
        /// </summary>
        SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Notification.INotificationPlatformService GetService(SmartDigitalPsico.Domain.Enuns.ENotificationServiceType serviceType);
    }
}
