using Microsoft.EntityFrameworkCore.Diagnostics;

namespace SmartDigitalPsico.Data.Audit.Interface
{
    public interface IAuditInterceptor
    {
        int SavedChanges(SaveChangesCompletedEventData eventData, int result);
    }
}