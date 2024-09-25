using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Domain.ModelEntity;
  
namespace SmartDigitalPsico.Data.Audit.Interface
{
    public interface IAuditService
    {
        List<AuditDataEntityLog> OnBeforeSaveChanges(DbContext context);
    }
}
