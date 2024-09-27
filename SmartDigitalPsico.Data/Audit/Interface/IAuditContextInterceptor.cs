using Microsoft.EntityFrameworkCore.Diagnostics;

namespace SmartDigitalPsico.Data.Audit.Interface
{
    public interface IAuditContextInterceptor
    {
        int SavedChanges(SaveChangesCompletedEventData eventData, int result);

        ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default);
    }
}