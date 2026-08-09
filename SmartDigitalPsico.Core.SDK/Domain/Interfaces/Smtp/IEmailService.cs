using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Notification;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Smtp
{
    /// <summary>
    /// Interface (contrato) responsável por IEmailService.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IEmailService : INotificationPlatformService
    {
    }
}
