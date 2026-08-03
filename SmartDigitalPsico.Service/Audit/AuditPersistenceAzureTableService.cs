using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Service.Audit
{
    /// <summary>
    /// Classe responsável por AuditPersistenceAzureTableService.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class AuditPersistenceAzureTableService : IAuditPersistenceService
    {
        // Implementação para salvar no Azure Storage Table
        /// <summary>
        /// Método SaveAuditEntries: cria ou persiste um novo registro/recurso.
        /// </summary>
        public void SaveAuditEntries(IEnumerable<AuditDataEntityLog> auditEntries)
        {
            // Código para salvar no Azure Storage Table
        }

        /// <summary>
        /// Método SaveAuditEntry: cria ou persiste um novo registro/recurso.
        /// </summary>
        public Task SaveAuditEntry(AuditDataSelectiveEntityLog auditEntry)
        {
            throw new NotImplementedException();
        }
    }
}
