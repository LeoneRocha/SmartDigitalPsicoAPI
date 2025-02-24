using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Interfaces.Service; 
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Interfaces.Notification;

namespace SmartDigitalPsico.Domain.DependeciesCollection
{
    public class SharedServices : ISharedServices
    {
        public ICacheService CacheService { get; }
        public ICryptoService CryptoService { get; }

        private readonly IServiceProvider _serviceProvider;

        public SharedServices(
            ICacheService cacheService,
            ICryptoService cryptoService, 
            IServiceProvider serviceProvider
        )
        {
            CacheService = cacheService;
            CryptoService = cryptoService;
            _serviceProvider = serviceProvider;
        }

        public IApplicationLanguageService ApplicationLanguageService
        {
            get
            {
                return _serviceProvider.GetService<IApplicationLanguageService>()
                    ?? throw new InvalidOperationException("IApplicationLanguageService not available.");
            }
        }
        public ISendNotificationService SendNotificationService
        {
            get
            {
                return _serviceProvider.GetService<ISendNotificationService>()
                    ?? throw new InvalidOperationException("ISendNotificationService not available.");
            }
        }
        public IEmailTemplateService EmailTemplateService
        {
            get
            {
                return _serviceProvider.GetService<IEmailTemplateService>()
                    ?? throw new InvalidOperationException("IEmailTemplateService not available.");
            }
        }
    }
}
