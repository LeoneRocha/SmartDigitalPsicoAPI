using SmartDigitalPsico.Domain.EntityModels.Schedule;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Interfaces.Audit
{
    /// <summary>
    /// Interface (contrato) responsável por IAuditPersistenceService.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IAuditPersistenceService
    {
        /// <summary>
        /// Método SaveAuditEntries: cria ou persiste um novo registro/recurso.
        /// </summary>
        void SaveAuditEntries(IEnumerable<AuditDataEntityLog> auditEntries);

        /// <summary>
        /// Método SaveAuditEntry: cria ou persiste um novo registro/recurso.
        /// </summary>
        Task SaveAuditEntry(AuditDataSelectiveEntityLog auditEntry);
    }
}
