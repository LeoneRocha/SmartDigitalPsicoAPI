using SmartDigitalPsico.Domain.Interfaces.Notification;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Interfaces.Service;

namespace SmartDigitalPsico.Domain.Interfaces.Collection
{
    public interface ISharedServices
    {
        IApplicationLanguageService ApplicationLanguageService { get; }
        ISendNotificationService SendNotificationService { get; }
        ICacheService CacheService { get; }
        ICryptoService CryptoService { get; }
        IEmailTemplateService EmailTemplateService { get; }
    }
}