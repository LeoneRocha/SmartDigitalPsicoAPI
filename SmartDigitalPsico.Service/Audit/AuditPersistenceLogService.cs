using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Service.Audit
{
    public class AuditPersistenceLogService : IAuditPersistenceService
    {
        private readonly Serilog.ILogger _logger;

        public AuditPersistenceLogService(Serilog.ILogger logger)
        {
            _logger = logger;
        }
        public void SaveAuditEntries(IEnumerable<AuditDataEntityLog> auditEntries)
        {
            foreach (var auditEntry in auditEntries)
            {
                _logger.Information(" Entity Edited | Table: {Table} | Operation: {Operation} | KeyValue: {KeyValues} | UserID: {UserID} | Date: {Date}",
                    auditEntry.TableName, auditEntry.Operation, auditEntry.KeyValue, auditEntry.UserAuditedId ?? 0, DataHelper.GetDateTimeCustomFormat(auditEntry.AuditDate));
            }
        } 
        public async Task SaveAuditEntry(AuditDataSelectiveEntityLog auditEntry)
        {
            await Task.Run(() =>
            {
                _logger.Information(" Entity Edited | Table: {Table} | Operation: {Operation} | KeyValue: {KeyValues} | UserID: {UserID} | Date: {Date}",
                   auditEntry.TableName, auditEntry.Operation, auditEntry.KeyValue, auditEntry.UserAuditedId ?? 0, DataHelper.GetDateTimeCustomFormat(auditEntry.AuditDate));
            });
        }
    }
}