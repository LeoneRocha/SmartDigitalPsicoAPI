using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Repository.Generic;

namespace SmartDigitalPsico.Repository.SystemDomains
{
    public class ApplicationCacheLogRepository : GenericRepositoryEntityBaseSimple<ApplicationCacheLog>, IApplicationCacheLogRepository 
    {
        public ApplicationCacheLogRepository(SmartDigitalPsicoDataContext context) : base(context) { }

        

        public async Task<bool> Delete(string cacheKey)
        {
            var result = await dataset.SingleOrDefaultAsync(p => p.CacheKey.ToLower().Equals(cacheKey.ToLower()));
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
    }
}
