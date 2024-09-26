using Microsoft.EntityFrameworkCore.Diagnostics;
using SmartDigitalPsico.Data.Audit.Interface;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Audit
{
    public class AuditContextInterceptor : SaveChangesInterceptor, IAuditContextInterceptor
    {
        private readonly IAuditContextService _auditService;
        private readonly IAuditPersistenceServiceFactory _auditPersistenceServiceFactory;
        private readonly IAuditPersistenceService _auditPersistenceService;
        private readonly EAuditServiceType _serviceType;

        public AuditContextInterceptor(IAuditContextService auditService, IAuditPersistenceServiceFactory auditPersistenceServiceFactory)
        {
            _serviceType = EAuditServiceType.Database;
            _auditService = auditService;
            _auditPersistenceServiceFactory = auditPersistenceServiceFactory;
            _auditPersistenceService = _auditPersistenceServiceFactory.CreateService(_serviceType);
        }
        public override int SavedChanges(SaveChangesCompletedEventData eventData, int result)
        {
            var auditEntries = _auditService.OnBeforeSaveChanges(eventData.Context!);

            if (_serviceType == EAuditServiceType.Database)
            {
                eventData!.Context!.Set<AuditDataEntityLog>().AddRange(auditEntries);
                return base.SavedChanges(eventData, result);
            }
            else
            {
                _auditPersistenceService.SaveAuditEntries(auditEntries);
            }
            return result;
        }

        public override async ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {
            var auditEntries = _auditService.OnBeforeSaveChanges(eventData.Context!);

            if (_serviceType == EAuditServiceType.Database)
            {
                eventData.Context!.Set<AuditDataEntityLog>().AddRange(auditEntries);
                return await base.SavingChangesAsync(eventData, result, cancellationToken);
            }
            else
            {
                _auditPersistenceService.SaveAuditEntries(auditEntries);
            }
            return result;
        }
    }
}