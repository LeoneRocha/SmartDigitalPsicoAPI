using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Data.Repository.Generic;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    public class ApplicationCacheLogRepository : GenericRepositoryEntityBase<ApplicationCacheLog>, IApplicationCacheLogRepository
    {
        public ApplicationCacheLogRepository(SmartDigitalPsicoDataContext context) : base(context) { }



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
