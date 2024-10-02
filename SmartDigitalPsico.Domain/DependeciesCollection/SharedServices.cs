using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.Interfaces.Smtp;

namespace SmartDigitalPsico.Domain.DependeciesCollection
{
    public class SharedServices : ISharedServices
    {
        public ICacheService CacheService { get; }
        public ICryptoService CryptoService { get; }

        public IEmailService EmailService   { get; }

    public SharedServices(
            ICacheService cacheService,
            ICryptoService cryptoService,
            IEmailService emailService
        )
        {
            CacheService = cacheService;
            CryptoService = cryptoService;
            EmailService = emailService;
        }
    }
}