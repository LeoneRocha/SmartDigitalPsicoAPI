namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface ICacheRepository
    {
        bool TryGet<T>(string cacheKey, out T value);
        bool Set<T>(string cacheKey, T value);
        bool Remove(string cacheKey);
    }

}
