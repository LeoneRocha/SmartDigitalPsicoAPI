using Microsoft.EntityFrameworkCore.Diagnostics;
using SmartDigitalPsico.Data.Audit.Interface;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Audit
{
    public class AuditInterceptor : SaveChangesInterceptor, IAuditInterceptor
    {
        private readonly IAuditService _auditService;

        public AuditInterceptor(IAuditService auditService)
        {
            _auditService = auditService;
        }

        public override int SavedChanges(SaveChangesCompletedEventData eventData, int result)
        {
            var auditEntries = _auditService.OnBeforeSaveChanges(eventData.Context!);
            eventData!.Context!.Set<AuditDataEntityLog>().AddRange(auditEntries);
            return base.SavedChanges(eventData, result);
        }

        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {
            var auditEntries = _auditService.OnBeforeSaveChanges(eventData.Context!);
            eventData!.Context!.Set<AuditDataEntityLog>().AddRange(auditEntries);
            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }
    }

}
