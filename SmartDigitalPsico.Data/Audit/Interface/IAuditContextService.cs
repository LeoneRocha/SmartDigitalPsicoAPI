using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Domain.ModelEntity;
  
namespace SmartDigitalPsico.Data.Audit.Interface
{
    public interface IAuditContextService
    {
        List<AuditDataEntityLog> OnBeforeSaveChanges(DbContext context);
    }
}
