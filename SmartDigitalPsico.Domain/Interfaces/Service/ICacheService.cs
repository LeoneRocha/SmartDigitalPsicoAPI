namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface ICacheService
    {
        bool TryGet<T>(string? cacheKey, out T value) where T : class, new();
        bool Set<T>(string? cacheKey, T value);
        bool Remove<T>(string? cacheKey);
        DateTime GetSlidingExpiration();
        bool IsEnable(); 
    }
}
