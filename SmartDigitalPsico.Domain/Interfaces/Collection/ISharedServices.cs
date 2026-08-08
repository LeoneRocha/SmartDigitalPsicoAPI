using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Service;

namespace SmartDigitalPsico.Domain.Interfaces.Collection
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
