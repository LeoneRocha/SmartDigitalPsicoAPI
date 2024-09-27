using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Domain.ModelEntity;
  
namespace SmartDigitalPsico.Data.Audit.Interface
{
    public interface IAuditContextService
    {
        List<AuditDataEntityLog> OnBeforeSaveChanges(DbContext context);
        List<AuditDataEntityLog> GetExistingEntries(DbContext context, List<AuditDataEntityLog> auditEntries);

        List<AuditDataEntityLog> GetNewEntries(DbContext context, List<AuditDataEntityLog> auditEntries);
    }
}
