using Microsoft.Extensions.Caching.Memory;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interface (contrato) responsável por IMemoryCacheRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IMemoryCacheRepository : ICacheRepository
    {

        bool Set<T>(string cacheKey, T value, MemoryCacheEntryOptions memoryCacheEntryOptions);

    }

}
