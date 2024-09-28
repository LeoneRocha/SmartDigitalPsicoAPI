using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class ApplicationCacheLogRepository : GenericRepositoryEntityBase<ApplicationCacheLog>, IApplicationCacheLogRepository
    {
        public ApplicationCacheLogRepository(IEntityDataContext context) : base(context) { }



        public async Task<bool> Delete(string cacheKey)
        {
            var result = await _dataset.SingleOrDefaultAsync(p => p.CacheKey.ToLower().Equals(cacheKey.ToLower()));
            if (result != null)
            {
                _dataset.Remove(result);
                await _context.SaveChangesAsync();
            }

            return true;
        }
    }
}
