using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using Sch = SmartCoreHub.Core.SDK.Infrastructure.Data;

namespace SmartDigitalPsico.Core.SDK.Data.Context;

/// <summary>
/// Casca do adapter DbContext → IEntityDataContext. SCH é sealed no NuGet atual; delega ao tipo canônico.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Data.DbContextEntityDataContextAdapter",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "AJ.1: casca sobre SCH sealed; implementa IEntityDataContext SDP.")]
public sealed class DbContextEntityDataContextAdapter : IEntityDataContext
{
    private readonly Sch.DbContextEntityDataContextAdapter _inner;

    /// <summary>Cria o adapter a partir de um <see cref="DbContext"/>.</summary>
    public DbContextEntityDataContextAdapter(DbContext dbContext)
    {
        _inner = new Sch.DbContextEntityDataContextAdapter(dbContext);
    }

    /// <inheritdoc />
    public DatabaseFacade Database => _inner.Database;

    /// <inheritdoc />
    public DbSet<TEntity> Set<TEntity>() where TEntity : class => _inner.Set<TEntity>();

    /// <inheritdoc />
    public EntityEntry Entry(object entity) => _inner.Entry(entity);

    /// <inheritdoc />
    public EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class => _inner.Entry(entity);

    /// <inheritdoc />
    public int SaveChanges() => _inner.SaveChanges();

    /// <inheritdoc />
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        => _inner.SaveChangesAsync(cancellationToken);

    /// <inheritdoc />
    public void Dispose() => _inner.Dispose();
}
