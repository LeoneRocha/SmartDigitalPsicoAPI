using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.Interfaces.Smtp;

namespace SmartDigitalPsico.Domain.Interfaces.Collection
{
    public interface ISharedServices
    {
        IApplicationLanguageService ApplicationLanguageService { get; }
        IEmailService EmailService { get; }
        ICacheService CacheService { get; }
        ICryptoService CryptoService { get; }    
    }
}