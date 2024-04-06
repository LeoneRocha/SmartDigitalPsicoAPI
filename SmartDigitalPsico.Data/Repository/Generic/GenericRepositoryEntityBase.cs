using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using System.Linq.Expressions;

namespace SmartDigitalPsico.Data.Repository.Generic
{
    public abstract class GenericRepositoryEntityBase<T> : IEntityBaseRepository<T> where T : EntityBase
    {
        protected SmartDigitalPsicoDataContext _context;

        protected DbSet<T> dataset;
        public GenericRepositoryEntityBase(SmartDigitalPsicoDataContext context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }

        public virtual async Task<List<T>> FindAll()
        {
            return await dataset.ToListAsync();
        }

        public virtual async Task<T?> FindByID(long id)
        {
            return await dataset.FirstOrDefaultAsync(p => p.Id.Equals(id)) ;
        }

        public virtual async Task<T> Create(T item)
        {
            try
            {
                //Fields internal change 
                item.CreatedDate = DataHelper.GetDateTimeNow();
                item.Enable = true;
                dataset.Add(item);
                await _context.SaveChangesAsync();
                return item;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual async Task<T> Update(T item)
        {
            var result = await dataset.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));
            if (result != null)
            {
                try
                {
                    //Fields internal change 
                    item.ModifyDate = DataHelper.GetDateTimeNow();

                    _context.Entry(result).CurrentValues.SetValues(item);
                    await _context.SaveChangesAsync();
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                return result;
            }
        }

        public virtual async Task<bool> Delete(long id)
        {
            var result = await dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    dataset.Remove(result);
                    await _context.SaveChangesAsync();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return true;
        }

        public virtual async Task<bool> EnableOrDisable(long id)
        {
            var result = await dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    try
                    {
                        result.Enable = !result.Enable;
                        await _context.SaveChangesAsync();

                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return true;
        }

        public virtual async Task<bool> Exists(long id)
        {
            return await dataset.AnyAsync(p => p.Id.Equals(id));
        }

        public virtual async Task<List<T>> FindWithPagedSearch(string query)
        {
            return await dataset.FromSqlRaw(query).ToListAsync();
        }

        public virtual async Task<List<T>> FindByCustomWhere(Expression<Func<T, bool>> predicate)
        {
            return await dataset.Where(predicate).ToListAsync();
        }

        public virtual async Task<List<T>> FindByCustomWhereWithIncludes(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = dataset.Where(predicate);

            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return await query.ToListAsync();
        }


        public virtual async Task<int> GetCount(string query)
        {
            int result = 0;
            using (var connection = _context.Database.GetDbConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    var resultAsyn = await command.ExecuteScalarAsync();

                    int.TryParse(resultAsyn.ToString(), out result);
                }
            }
            return result;
        }
    }
}
