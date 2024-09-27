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
        private readonly IAuditPersistenceService _auditPersistenceService;
        private readonly EAuditServiceType _serviceType;

        public AuditContextInterceptor(IAuditContextService auditService, IAuditPersistenceServiceFactory auditPersistenceServiceFactory)
        {
            _serviceType = EAuditServiceType.Database;
            _auditService = auditService;
            _auditPersistenceService = auditPersistenceServiceFactory.CreateService(_serviceType);
        }
        public override int SavedChanges(SaveChangesCompletedEventData eventData, int result)
        {
            var auditEntries = _auditService.OnBeforeSaveChanges(eventData.Context!);

            if (auditEntries.Count > 0)
            {
                if (_serviceType == EAuditServiceType.Database)
                {
                    var context = eventData.Context!;
                    var newEntries = _auditService.GetNewEntries(context, auditEntries);

                    if (newEntries.Count > 0)
                    {
                        context.Set<AuditDataEntityLog>().AddRange(newEntries);
                        return base.SavedChanges(eventData, result);
                    }
                }
                else
                {
                    _auditPersistenceService.SaveAuditEntries(auditEntries);
                }
            }
            return result;
        }

        public override async ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {
            var auditEntries = _auditService.OnBeforeSaveChanges(eventData.Context!);
            if (auditEntries.Count > 0)
            {
                if (_serviceType == EAuditServiceType.Database)
                {
                    var context = eventData.Context!;
                    var newEntries = _auditService.GetNewEntries(context, auditEntries);

                    if (newEntries.Count > 0)
                    {
                        context.Set<AuditDataEntityLog>().AddRange(newEntries);
                        return await base.SavingChangesAsync(eventData, result, cancellationToken);
                    } 
                }
                else
                {
                    _auditPersistenceService.SaveAuditEntries(auditEntries);
                }
            }
            return result;
        }
    }
}