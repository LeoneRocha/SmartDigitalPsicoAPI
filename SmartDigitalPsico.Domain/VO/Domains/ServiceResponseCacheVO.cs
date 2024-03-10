using SmartDigitalPsico.Domain.Contracts.Interface;
using SmartDigitalPsico.Domain.Hypermedia.Utils;

namespace SmartDigitalPsico.Domain.VO.Domains
{
    public class ServiceResponseCacheVO<T> : ServiceResponse<T>, IDataCacheVO<T>
    {
        public ServiceResponseCacheVO()
        {

        }
        public ServiceResponseCacheVO(IServiceResponse<T> serviceResponse
            , string cacheKey, DateTime dateTimeSlidingExpiration)
        {
            CacheKey = cacheKey;
            CacheId = Guid.NewGuid().ToString();
            DateTimeSlidingExpiration = dateTimeSlidingExpiration;
            Data = serviceResponse.Data;
            Success = serviceResponse.Success;
            Message = serviceResponse.Message;
        }
        public ServiceResponseCacheVO(T dataToCache
           , string cacheKey, DateTime dateTimeSlidingExpiration)
        {
            CacheKey = cacheKey;
            CacheId = Guid.NewGuid().ToString();
            DateTimeSlidingExpiration = dateTimeSlidingExpiration;
            Data = dataToCache;
            Success = true;
            Message = string.Empty;
        }


        public DateTime DateTimeSlidingExpiration { get; set; }
        public string CacheKey { get; set; } = string.Empty;
        public string CacheId { get; set; } = string.Empty;

    }
}
