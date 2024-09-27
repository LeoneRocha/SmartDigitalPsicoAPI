using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Service.Audit
{
    public class AuditPersistenceDataBaseService : IAuditPersistenceService
    { 
        public AuditPersistenceDataBaseService()
        {            
        }
        public void SaveAuditEntries(IEnumerable<AuditDataEntityLog> auditEntries)
        {
        }
        public async Task SaveAuditEntry(AuditDataSelectiveEntityLog auditEntry)
        {
            await Task.Run(() =>
            { 
            });
        }
    }
}
