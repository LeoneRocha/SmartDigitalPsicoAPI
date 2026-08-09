using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Core.SDK.Data.Context;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using SmartDigitalPsico.Core.SDK.Domain.Contracts;
using SmartDigitalPsico.Core.SDK.Domain.Helpers;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Core.SDK.Data.Repository.Generic
{
    /// <summary>
    /// Repositório genérico EF baseado em IEntityDataContext canônico.
    /// </summary>
    public abstract class GenericRepositoryEntityBase<T> : IEntityBaseRepository<T> where T : EntityBase
    {
        protected IEntityDataContext _context;
        protected DbSet<T> _dataset;

        protected GenericRepositoryEntityBase(IEntityDataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dataset = _context.Set<T>();
        }

        /// <summary>
        /// Conveniência para DbContext concreto (produção tipada / testes InMemory).
        /// </summary>
        protected GenericRepositoryEntityBase(DbContext context)
            : this(new DbContextEntityDataContextAdapter(context))
        {
        }

        /// <summary>
        /// Construtor para mocks de teste que fornecem DbSet diretamente.
        /// </summary>
        protected GenericRepositoryEntityBase(DbSet<T> dataset, IEntityDataContext? context = null)
        {
            _dataset = dataset ?? throw new ArgumentNullException(nameof(dataset));
            _context = context!;
        }

        protected GenericRepositoryEntityBase(DbSet<T> dataset, DbContext? context)
            : this(dataset, context == null ? null : new DbContextEntityDataContextAdapter(context))
        {
        }

        public virtual async Task<List<T>> FindAll()
        {
            return await _dataset.AsNoTracking().ToListAsync();
        }

        public virtual async Task<T> FindByID(long id)
        {
            return await _dataset.FirstAsync(p => p.Id.Equals(id));
        }

        public virtual async Task<T> FindByID(long id, Action<IQueryable<T>> includeAction)
        {
            IQueryable<T> query = _dataset;
            includeAction(query);
            return await query.FirstAsync(p => p.Id.Equals(id));
        }

        public virtual async Task<T> FindByID(long id, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _dataset;
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return await query.FirstAsync(p => p.Id.Equals(id));
        }

        public virtual async Task<T?> FindAsync(long id, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _dataset;
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return await query.FirstOrDefaultAsync(p => p.Id.Equals(id));
        }

        public virtual async Task<T> Create(T item)
        {
            item.CreatedDate = DateHelper.GetDateTimeNowFromUtc();
            item.Enable = true;
            await _dataset.AddAsync(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public virtual async Task<T> Update(T item)
        {
            var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));
            if (result != null)
            {
                item.ModifyDate = DateHelper.GetDateTimeNowFromUtc();
                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Register not found");
            }
            return result;
        }

        public virtual async Task<bool> Delete(long id)
        {
            var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
            if (result != null)
            {
                _dataset.Remove(result);
                await _context.SaveChangesAsync();
            }
            return true;
        }

        public virtual async Task<bool> EnableOrDisable(long id)
        {
            var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
            if (result != null)
            {
                result.Enable = !result.Enable;
                await _context.SaveChangesAsync();
            }
            return true;
        }

        public virtual async Task<bool> Exists(long id)
        {
            return await _dataset.AsNoTracking().AnyAsync(p => p.Id.Equals(id));
        }

        public virtual async Task FindExistsByID(long id)
        {
            await _dataset.AsNoTracking().Select(x => x.Id).FirstAsync(p => p.Equals(id));
        }

        public virtual async Task<List<T>> FindByCustomWhere(Expression<Func<T, bool>> predicate)
        {
            return await _dataset.Where(predicate).ToListAsync();
        }

        public virtual async Task<List<T>> FindByCustomWhereWithIncludes(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dataset.Where(predicate);
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return await query.ToListAsync();
        }

        public virtual async Task<int> GetCount(Expression<Func<T, bool>> predicate)
        {
            return await _dataset.AsNoTracking().CountAsync(predicate);
        }
    }
}
