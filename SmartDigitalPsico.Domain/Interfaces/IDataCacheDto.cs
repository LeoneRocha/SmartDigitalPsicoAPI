namespace SmartDigitalPsico.Domain.Interfaces
{

    public interface IDataCacheDto<T>
    {
        public string CacheKey { get; }
        public string CacheId { get; }
        public DateTime DateTimeSlidingExpiration { get; }

        public T? Data { get; set; }
    }
}