using System.Linq.Expressions;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IEntityBaseRepository<T> where T : IEntityBase
    {
        Task<T> Create(T item);
        Task<T> FindByID(long id);
        Task<T> FindByID(long id, params Expression<Func<T, object>>[] includes);
        Task<T> FindByID(long id, Action<IQueryable<T>> includeAction);
        Task<T?> FindAsync(long id, params Expression<Func<T, object>>[] includes);
        Task<List<T>> FindAll();
        Task<List<T>> FindByCustomWhere(Expression<Func<T, bool>> predicate);
        Task<List<T>> FindByCustomWhereWithIncludes(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        Task FindExistsByID(long id);
        Task<T> Update(T item);
        Task<bool> Delete(long id);
        Task<bool> EnableOrDisable(long id);
        Task<bool> Exists(long id);
        Task<int> GetCount(Expression<Func<T, bool>> predicate); 
    }
}