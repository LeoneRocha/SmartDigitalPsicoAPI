using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;

namespace SmartDigitalPsico.Core.SDK.Data.Context
{
    /// <summary>
    /// Adapta DbContext concreto para IEntityDataContext genérico (útil em testes InMemory).
    /// </summary>
    public sealed class DbContextEntityDataContextAdapter : IEntityDataContext
    {
        private readonly DbContext _dbContext;

        public DbContextEntityDataContextAdapter(DbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public DatabaseFacade Database => _dbContext.Database;

        public DbSet<TEntity> Set<TEntity>() where TEntity : class => _dbContext.Set<TEntity>();

        public EntityEntry Entry(object entity) => _dbContext.Entry(entity);

        public EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class => _dbContext.Entry(entity);

        public int SaveChanges() => _dbContext.SaveChanges();

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
            => _dbContext.SaveChangesAsync(cancellationToken);

        public void Dispose() => _dbContext.Dispose();
    }
}
