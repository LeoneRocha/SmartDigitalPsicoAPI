using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Logging;
using SmartDigitalPsico.Domain.ModelEntity;

using SmartDigitalPsico.Domain.Interfaces.Audit;
namespace SmartDigitalPsico.Service.Audit
{
    /// <summary>
    /// Classe responsável por AuditPersistenceLogService.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class AuditPersistenceLogService : IAuditPersistenceService
    {
        private readonly IAppLogger _logger;

        /// <summary>
        /// Método AuditPersistenceLogService: executa a operação AuditPersistenceLogService.
        /// </summary>
        public AuditPersistenceLogService(IAppLogger logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Método SaveAuditEntries: cria ou persiste um novo registro/recurso.
        /// </summary>
        public void SaveAuditEntries(IEnumerable<AuditDataEntityLog> auditEntries)
        {
            foreach (var auditEntry in auditEntries)
            {
                _logger.Information(" Entity Edited | Table: {Table} | Operation: {Operation} | KeyValue: {KeyValues} | UserID: {UserID} | Date: {Date}",
                    auditEntry.TableName, auditEntry.Operation, auditEntry.KeyValue, auditEntry.UserAuditedId ?? 0, SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeCustomFormat(auditEntry.AuditDate));
            }
        } 
        /// <summary>
        /// Método SaveAuditEntry: cria ou persiste um novo registro/recurso.
        /// </summary>
        public async Task SaveAuditEntry(AuditDataSelectiveEntityLog auditEntry)
        {
            await Task.Run(() =>
            {
                _logger.Information(" Entity Edited | Table: {Table} | Operation: {Operation} | KeyValue: {KeyValues} | UserID: {UserID} | Date: {Date}",
                   auditEntry.TableName, auditEntry.Operation, auditEntry.KeyValue, auditEntry.UserAuditedId ?? 0, SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeCustomFormat(auditEntry.AuditDate));
            });
        }
    }
}
