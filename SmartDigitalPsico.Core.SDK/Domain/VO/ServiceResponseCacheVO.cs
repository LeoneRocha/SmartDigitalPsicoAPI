using SmartDigitalPsico.Core.SDK.Domain.Interfaces;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.VO;

namespace SmartDigitalPsico.Core.SDK.Domain.VO
{
    /// <summary>
    /// Classe responsável por ServiceResponseCacheVO.
    /// Responsabilidade: value object / objeto de valor de resposta.
    /// Relação: retornado pelos Services para Controllers.
    /// </summary>
    public class ServiceResponseCacheVO<T> : ServiceResponse<T>, IDataCacheDto<T>
    {
        /// <summary>
        /// Método ServiceResponseCacheVO: executa a operação ServiceResponseCacheVO.
        /// </summary>
        public ServiceResponseCacheVO()
        {
        }
        /// <summary>
        /// Método ServiceResponseCacheVO: executa a operação ServiceResponseCacheVO.
        /// </summary>
        public ServiceResponseCacheVO(IServiceResponse<T> serviceResponse
            , string cacheKey, DateTime dateTimeSlidingExpiration)
        {
            CacheKey = cacheKey;
            CacheId = Guid.NewGuid().ToString();
            DateTimeSlidingExpiration = dateTimeSlidingExpiration;
            Data = serviceResponse.Data;
            Message = serviceResponse.Message;
            if (serviceResponse is ServiceResponse<T> full)
            {
                Errors = full.Errors ?? new List<ErrorResponse>();
                Unauthorized = full.Unauthorized;
            }
            else if (!serviceResponse.Success)
            {
                Errors =
                [
                    new ErrorResponse
                    {
                        Name = "Cache",
                        Message = string.IsNullOrWhiteSpace(serviceResponse.Message)
                            ? "Cached failure."
                            : serviceResponse.Message
                    }
                ];
            }
        }
        /// <summary>
        /// Método ServiceResponseCacheVO: executa a operação ServiceResponseCacheVO.
        /// </summary>
        public ServiceResponseCacheVO(T dataToCache
           , string cacheKey, DateTime dateTimeSlidingExpiration)
        {
            CacheKey = cacheKey;
            CacheId = Guid.NewGuid().ToString();
            DateTimeSlidingExpiration = dateTimeSlidingExpiration;
            Data = dataToCache;
            Message = string.Empty;
        }

        public DateTime DateTimeSlidingExpiration { get; private set; }
        public string CacheKey { get; private set; } = string.Empty;
        public string CacheId { get; private set; } = string.Empty;

    }
}
