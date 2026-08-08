using SmartDigitalPsico.Domain.ModelEntity;

using SmartDigitalPsico.Domain.Interfaces.Audit;
namespace SmartDigitalPsico.Service.Audit
{
    /// <summary>
    /// Classe responsável por AuditPersistenceDataBaseService.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class AuditPersistenceDataBaseService : IAuditPersistenceService
    { 
        /// <summary>
        /// Método AuditPersistenceDataBaseService: executa a operação AuditPersistenceDataBaseService.
        /// </summary>
        public AuditPersistenceDataBaseService()
        {            
        }
        /// <summary>
        /// Método SaveAuditEntries: cria ou persiste um novo registro/recurso.
        /// </summary>
        public void SaveAuditEntries(IEnumerable<AuditDataEntityLog> auditEntries)
        {
        }
        /// <summary>
        /// Método SaveAuditEntry: cria ou persiste um novo registro/recurso.
        /// </summary>
        public async Task SaveAuditEntry(AuditDataSelectiveEntityLog auditEntry)
        {
            await Task.Run(() =>
            { 
            });
        }
    }
}
