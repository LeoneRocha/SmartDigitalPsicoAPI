using SmartDigitalPsico.Domain.Enuns;

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
        INotificationPlatformService GetService(ENotificationServiceType serviceType);
    }
}
