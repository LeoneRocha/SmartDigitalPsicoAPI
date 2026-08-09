using Microsoft.Extensions.DependencyInjection;

using SmartDigitalPsico.Domain.Interfaces.Application;
using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Notification;
namespace SmartDigitalPsico.Domain.DependeciesCollection
{
    /// <summary>
    /// Classe responsável por SharedServices.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class SharedServices : ISharedServices
    {
        public SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService CacheService { get; }
        public SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security.ICryptoService CryptoService { get; }

        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// Método SharedServices: executa a operação SharedServices.
        /// </summary>
        public SharedServices(
            SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.ICacheService cacheService,
            SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security.ICryptoService cryptoService,
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
        public INotificationTemplateService NotificationTemplateService
        {
            get
            {
                return _serviceProvider.GetService<INotificationTemplateService>()
                    ?? throw new InvalidOperationException("INotificationTemplateService not available.");
            }
        }
    }
}
