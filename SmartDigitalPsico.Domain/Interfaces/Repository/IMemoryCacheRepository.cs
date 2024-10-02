using Microsoft.Extensions.Caching.Memory;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IMemoryCacheRepository : ICacheRepository
    {

       bool Set<T>(string cacheKey, T value, MemoryCacheEntryOptions memoryCacheEntryOptions);

    }

}
