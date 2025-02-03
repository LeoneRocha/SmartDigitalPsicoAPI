using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.Interfaces.Smtp;
using Microsoft.Extensions.DependencyInjection;

namespace SmartDigitalPsico.Domain.DependeciesCollection
{
    public class SharedServices : ISharedServices
    {
        public ICacheService CacheService { get; }
        public ICryptoService CryptoService { get; }
        public IEmailService EmailService { get; }
        private readonly IServiceProvider _serviceProvider;

        public SharedServices(
            ICacheService cacheService,
            ICryptoService cryptoService,
            IEmailService emailService,
            IServiceProvider serviceProvider
        )
        {
            CacheService = cacheService;
            CryptoService = cryptoService;
            EmailService = emailService;
            _serviceProvider = serviceProvider;
        }

        //public IApplicationLanguageService? ApplicationLanguageService
        //{
        //    get
        //    {
        //        return _serviceProvider.GetService<IApplicationLanguageService>() ?? new instacn IApplicationLanguageService();
        //    }
        //}

    }
}
