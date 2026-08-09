using Microsoft.EntityFrameworkCore;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Audit.Interface
{
    /// <summary>
    /// Interface (contrato) responsável por IAuditContextService.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IAuditContextService
    {
        /// <summary>
        /// Método OnBeforeSaveChanges: executa a operação OnBeforeSaveChanges.
        /// </summary>
        List<AuditDataEntityLog> OnBeforeSaveChanges(DbContext context);

        /// <summary>
        /// Método GetNewEntries: consulta e retorna dados.
        /// </summary>
        List<AuditDataEntityLog> GetNewEntries(DbContext context, List<AuditDataEntityLog> auditEntriesInput);
        /// <summary>
        /// Método GetExistingEntries: consulta e retorna dados.
        /// </summary>
        List<AuditDataEntityLog> GetExistingEntries(DbContext context, List<AuditDataEntityLog> auditEntriesInput);
    }
}
