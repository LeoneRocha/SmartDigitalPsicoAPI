using Microsoft.EntityFrameworkCore;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Contracts;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using System.Linq.Expressions;


namespace SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Generic
{
    /// <summary>
    /// Classe responsável por GenericRepositoryEntityBase.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public abstract class GenericRepositoryEntityBase<T> : IEntityBaseRepository<T> where T : EntityBase
    {
        protected DbContext _context;
        protected DbSet<T> _dataset;

        /// <summary>
        /// Método GenericRepositoryEntityBase: executa a operação GenericRepositoryEntityBase.
        /// </summary>
        protected GenericRepositoryEntityBase(DbContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }

        /// <summary>
        /// Construtor para hosts que expõem DbSet via interface (ex.: IEntityDataContext / mocks de teste).
        /// </summary>
        protected GenericRepositoryEntityBase(DbSet<T> dataset, DbContext? context = null)
        {
            _dataset = dataset ?? throw new ArgumentNullException(nameof(dataset));
            _context = context!;
        }

        /// <summary>
        /// Método FindAll: consulta e retorna dados.
        /// </summary>
        public virtual async Task<List<T>> FindAll()
        {
            return await _dataset.AsNoTracking().ToListAsync();
        }

        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        public virtual async Task<T> FindByID(long id)
        {
            return await _dataset.FirstAsync(p => p.Id.Equals(id));
        }
        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        public virtual async Task<T> FindByID(long id, Action<IQueryable<T>> includeAction)
        {
            IQueryable<T> query = _dataset;
            includeAction(query);
            return await query.FirstAsync(p => p.Id.Equals(id));
        }
        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        public virtual async Task<T> FindByID(long id, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _dataset;
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return await query.FirstAsync(p => p.Id.Equals(id));
        }
        /// <summary>
        /// Método FindAsync: consulta e retorna dados.
        /// </summary>
        public virtual async Task<T?> FindAsync(long id, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _dataset;
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return await query.FirstOrDefaultAsync(p => p.Id.Equals(id));
        }

        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        public virtual async Task<T> Create(T item)
        {
            //Fields internal change 
            item.CreatedDate = DateHelper.GetDateTimeNowFromUtc();
            item.Enable = true;
            await _dataset.AddAsync(item);
            await _context.SaveChangesAsync();
            return item;
        }

        /// <summary>
        /// Método Update: atualiza um registro/recurso existente.
        /// </summary>
        public virtual async Task<T> Update(T item)
        {
            var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));
            if (result != null)
            {
                //Fields internal change 
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

        /// <summary>
        /// Método Delete: remove ou cancela um registro/recurso.
        /// </summary>
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

        /// <summary>
        /// Método EnableOrDisable: altera o estado de habilitação do recurso.
        /// </summary>
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

        /// <summary>
        /// Método Exists: valida regras ou verifica existência.
        /// </summary>
        public virtual async Task<bool> Exists(long id)
        {
            return await _dataset.AsNoTracking().AnyAsync(p => p.Id.Equals(id));
        }

        /// <summary>
        /// Método FindExistsByID: consulta e retorna dados.
        /// </summary>
        public virtual async Task FindExistsByID(long id)
        {
            await _dataset.AsNoTracking().Select(x => x.Id).FirstAsync(p => p.Equals(id));
        }

        /// <summary>
        /// Método FindByCustomWhere: consulta e retorna dados.
        /// </summary>
        public virtual async Task<List<T>> FindByCustomWhere(Expression<Func<T, bool>> predicate)
        {
            return await _dataset.Where(predicate).ToListAsync();
        }

        /// <summary>
        /// Método FindByCustomWhereWithIncludes: consulta e retorna dados.
        /// </summary>
        public virtual async Task<List<T>> FindByCustomWhereWithIncludes(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dataset.Where(predicate);

            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return await query.ToListAsync();
        }

        /// <summary>
        /// Método GetCount: consulta e retorna dados.
        /// </summary>
        public virtual async Task<int> GetCount(Expression<Func<T, bool>> predicate)
        {
            return await _dataset.AsNoTracking().CountAsync(predicate);
        }
    }
}
