using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Audit;

namespace SmartDigitalPsico.Service.Audit
{
    public class AuditPersistenceServiceFactory : IAuditPersistenceServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public AuditPersistenceServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public IAuditPersistenceService CreateService(EAuditServiceType serviceType)
        {
            switch (serviceType)
            {
                case EAuditServiceType.Database:
                    return _serviceProvider.GetService<AzureTableAuditPersistenceService>()!;
                case EAuditServiceType.AzureTable:
                    return _serviceProvider.GetService<AzureTableAuditPersistenceService>()!;
                case EAuditServiceType.Log:
                    return _serviceProvider.GetService<LogAuditPersistenceService>()!;
                default:
                    throw new ArgumentException("Invalid service type", nameof(serviceType));
            }
        }
    }
}
