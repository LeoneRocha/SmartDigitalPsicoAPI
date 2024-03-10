namespace SmartDigitalPsico.Domain.Contracts.Interface
{

    public interface IDataCacheVO<T>
    {
        public string CacheKey { get; set; }
        public string CacheId { get; set; }
        public DateTime DateTimeSlidingExpiration { get; set; }

        public T? Data { get; set; }
    }
}