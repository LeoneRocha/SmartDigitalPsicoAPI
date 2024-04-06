using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IApplicationCacheLogRepository : IEntityBaseRepository<ApplicationCacheLog>
    {
        Task<bool> Delete(string cacheKey);
    }
}
