using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.VO;

namespace SmartDigitalPsico.Domain.VO
{
    /// <summary>
    /// Classe responsável por ServiceResponseCacheVO.
    /// Responsabilidade: value object / objeto de valor de resposta.
    /// Relação: retornado pelos Services para Controllers.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
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
            Success = serviceResponse.Success;
            Message = serviceResponse.Message;
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
            Success = true;
            Message = string.Empty;
        }


        public DateTime DateTimeSlidingExpiration { get; private set; }
        public string CacheKey { get; private set; } = string.Empty;
        public string CacheId { get; private set; } = string.Empty;

    }
}
