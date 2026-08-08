using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.VO;

namespace SmartDigitalPsico.Domain.VO
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class ServiceResponseCacheVO<T> : SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponseCacheVO<T>, IDataCacheDto<T>
    {
        public ServiceResponseCacheVO() : base() { }

        public ServiceResponseCacheVO(IServiceResponse<T> serviceResponse, string cacheKey, DateTime dateTimeSlidingExpiration)
            : base(serviceResponse, cacheKey, dateTimeSlidingExpiration) { }

        public ServiceResponseCacheVO(T dataToCache, string cacheKey, DateTime dateTimeSlidingExpiration)
            : base(dataToCache, cacheKey, dateTimeSlidingExpiration) { }
    }
}
