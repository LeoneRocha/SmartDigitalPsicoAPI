using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

using SmartDigitalPsico.Domain.Interfaces.Audit;
namespace SmartDigitalPsico.Service.Audit
{
    /// <summary>
    /// Classe responsável por AuditPersistenceServiceFactory.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class AuditPersistenceServiceFactory : IAuditPersistenceServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;

        /// <summary>
        /// Método AuditPersistenceServiceFactory: executa a operação AuditPersistenceServiceFactory.
        /// </summary>
        public AuditPersistenceServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        /// <summary>
        /// Método CreateService: cria ou persiste um novo registro/recurso.
        /// </summary>
        public IAuditPersistenceService CreateService(EAuditServiceType serviceType)
        {
            switch (serviceType)
            {
                case EAuditServiceType.Database:
                    return _serviceProvider.GetService<AuditPersistenceDataBaseService>()!;
                case EAuditServiceType.AzureTable:
                    return _serviceProvider.GetService<AuditPersistenceAzureTableService>()!;
                case EAuditServiceType.Log:
                    return _serviceProvider.GetService<AuditPersistenceLogService>()!;
                default:
                    throw new ArgumentException("Invalid service type", nameof(serviceType));
            }
        }
    }
}
