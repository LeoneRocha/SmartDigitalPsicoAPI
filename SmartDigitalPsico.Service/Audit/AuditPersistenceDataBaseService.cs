using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Service.Audit
{
    public class AuditPersistenceDataBaseService : IAuditPersistenceService
    {
        //private readonly IAuditDataSelectiveEntityLogRepository _entityRepository;

        public AuditPersistenceDataBaseService(/*IAuditDataSelectiveEntityLogRepository entityRepository*/)
        {
            //_entityRepository = entityRepository;
        }
        public void SaveAuditEntries(IEnumerable<AuditDataEntityLog> auditEntries)
        {
        }
        public async Task SaveAuditEntry(AuditDataSelectiveEntityLog auditEntry)
        {
            //await _entityRepository.Create(auditEntry);
        }
    }
}
