using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using SmartDigitalPsico.Core.SDK.Data.Repository.Generic;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Repository.SystemDomains
{
    /// <summary>
    /// Classe responsável por ApplicationCacheLogRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: implementa interfaces do Domain e usa o EF Core Context.
    /// </summary>
    public class ApplicationCacheLogRepository : SmartDigitalPsico.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<ApplicationCacheLog>, IApplicationCacheLogRepository
    {
        /// <summary>
        /// Método ApplicationCacheLogRepository: executa a operação ApplicationCacheLogRepository.
        /// </summary>
        public ApplicationCacheLogRepository(IEntityDataContext context) : base(context) { }



        /// <summary>
        /// Método Delete: remove ou cancela um registro/recurso.
        /// </summary>
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
