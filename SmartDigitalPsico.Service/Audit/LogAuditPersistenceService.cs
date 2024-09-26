using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Service.Audit
{
    public class LogAuditPersistenceService : IAuditPersistenceService
    {
        private readonly Serilog.ILogger _logger;

        public LogAuditPersistenceService(Serilog.ILogger logger)
        {
            _logger = logger;
        } 
        public void SaveAuditEntries(IEnumerable<AuditDataEntityLog> auditEntries)
        {
            foreach (var entry in auditEntries)
            { 
                _logger.Information(" Entity Edited | Table: {Table} | Operation: {Operation} | KeyValue: {KeyValues} | UserID: {UserID} | Date: {Date}", 
                    entry.TableName, entry.Operation, entry.KeyValue, entry.UserAuditedId ?? 0, DataHelper.GetDateTimeCustomFormat(entry.AuditDate));
            }
        }
    }
}