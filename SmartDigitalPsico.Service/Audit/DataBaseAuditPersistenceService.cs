using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Service.Audit
{
    public class DataBaseAuditPersistenceService : IAuditPersistenceService
    {
        // Implementação para salvar no Azure Storage Table
        public void SaveAuditEntries(IEnumerable<AuditDataEntityLog> auditEntries)
        {
            // Código para salvar no Azure Storage Table
        }
    }
}
