using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.VO;

namespace SmartDigitalPsico.Domain.VO
{
    public class ServiceResponseCacheVO<T> : ServiceResponse<T>, IDataCacheDto<T>
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


        public DateTime DateTimeSlidingExpiration { get; private set; }
        public string CacheKey { get; private set; } = string.Empty;
        public string CacheId { get; private set; } = string.Empty;

    }
}
