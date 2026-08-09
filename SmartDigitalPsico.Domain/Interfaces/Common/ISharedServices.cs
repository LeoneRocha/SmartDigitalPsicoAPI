using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.Interfaces.Notification;

namespace SmartDigitalPsico.Domain.Interfaces.Common
{
    /// <summary>
    /// Interface (contrato) responsável por ISharedServices.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface ISharedServices
    {
        IApplicationLanguageService ApplicationLanguageService { get; }
        ISendNotificationService SendNotificationService { get; }
        SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService CacheService { get; }
        SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security.ICryptoService CryptoService { get; }
        INotificationTemplateService NotificationTemplateService { get; }
    }
}
