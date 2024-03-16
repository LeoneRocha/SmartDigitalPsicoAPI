using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IApplicationCacheLogRepository : IEntityBaseSimpleRepository<ApplicationCacheLog>
    {
        Task<bool> Delete(string cacheKey);
    }
}
