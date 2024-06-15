using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Resiliency;
using System.Linq.Expressions;


namespace SmartDigitalPsico.Data.Repository.Generic
{
    public abstract class GenericRepositoryEntityBase<T> : IEntityBaseRepository<T> where T : EntityBase
    {
        protected SmartDigitalPsicoDataContext _context;
        private readonly IPolicyConfig _policyConfig;
        protected DbSet<T> _dataset;
        protected GenericRepositoryEntityBase(SmartDigitalPsicoDataContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
            _policyConfig = new PolicyConfig();
        }

        /// <summary>
        /// Precisa depois refazer arquitetura para passar por config no repositorio
        /// </summary>
        /// <param name="context"></param>
        /// <param name="policyConfig"></param>
        protected GenericRepositoryEntityBase(SmartDigitalPsicoDataContext context, IPolicyConfig policyConfig)
        {
            _context = context;
            _dataset = _context.Set<T>();
            _policyConfig = policyConfig;
        }

        public virtual async Task<List<T>> FindAll()
        {
            return await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
            {
                return await _dataset.AsNoTracking().ToListAsync();
            });
        }

        public virtual async Task<T> FindByID(long id)
        {
            return await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
            {
                return await _dataset.FirstAsync(p => p.Id.Equals(id));
            });
        }
        public virtual async Task<T> Create(T item)
        {
            //Fields internal change 
            item.CreatedDate = DataHelper.GetDateTimeNow();
            item.Enable = true;
            await _dataset.AddAsync(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public virtual async Task<T> Update(T item)
        {
            return await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));
                if (result != null)
                {
                    //Fields internal change 
                    item.ModifyDate = DataHelper.GetDateTimeNow();

                    _context.Entry(result).CurrentValues.SetValues(item);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    throw new InvalidOperationException("Register not found");
                }
                return result;
            });
        }

        public virtual async Task<bool> Delete(long id)
        {
            return await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
                if (result != null)
                {
                    _dataset.Remove(result);
                    await _context.SaveChangesAsync();
                }
                return true;
            });
        }

        public virtual async Task<bool> EnableOrDisable(long id)
        {
            return await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
                if (result != null)
                {
                    result.Enable = !result.Enable;
                    await _context.SaveChangesAsync();
                }
                return true;
            });
        }

        public virtual async Task<bool> Exists(long id)
        {
            return await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
            {
                return await _dataset.AsNoTracking().AnyAsync(p => p.Id.Equals(id));
            });
        }

        public virtual async Task FindExistsByID(long id)
        {
            await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
            {
                await _dataset.AsNoTracking().Select(x => x.Id).FirstAsync(p => p.Equals(id));
            });
        }

        public virtual async Task<List<T>> FindByCustomWhere(Expression<Func<T, bool>> predicate)
        {
            return await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
            {
                return await _dataset.Where(predicate).ToListAsync();
            });
        }

        public virtual async Task<List<T>> FindByCustomWhereWithIncludes(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            return await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
            {
                IQueryable<T> query = _dataset.Where(predicate);

                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
                return await query.ToListAsync();
            });
        }

        public virtual async Task<int> GetCount(Expression<Func<T, bool>> predicate)
        {
            return await ResiliencePolicies.GetPolicyFromConfig(_policyConfig).ExecuteAsync(async () =>
            {
                return await _dataset.AsNoTracking().CountAsync(predicate);
            });
        }
    }
}