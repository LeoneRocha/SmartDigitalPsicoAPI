using Microsoft.EntityFrameworkCore.Diagnostics;

namespace SmartDigitalPsico.Data.Audit.Interface
{
    /// <summary>
    /// Interface (contrato) responsável por IAuditContextInterceptor.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IAuditContextInterceptor
    {
        /// <summary>
        /// Método SavedChanges: cria ou persiste um novo registro/recurso.
        /// </summary>
        int SavedChanges(SaveChangesCompletedEventData eventData, int result);

        /// <summary>
        /// Método SavingChangesAsync: executa a operação SavingChangesAsync.
        /// </summary>
        ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default);
    }
}
