using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Audit
{
    public interface IAuditPersistenceService
    {
        void SaveAuditEntries(IEnumerable<AuditDataEntityLog> auditEntries);

        Task SaveAuditEntry(AuditDataSelectiveEntityLog auditEntry);
    }
}
