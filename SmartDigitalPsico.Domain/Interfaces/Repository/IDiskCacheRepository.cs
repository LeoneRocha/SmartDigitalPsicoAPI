namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IDiskCacheRepository  
    {
        public Task<KeyValuePair<bool, T>> TryGetAsync<T>(string cacheKey) where T : new();

        public Task<bool> RemoveAsync(string cacheKey);

        public Task<bool> SetAsync<T>(string cacheKey, T value);
    }

}
