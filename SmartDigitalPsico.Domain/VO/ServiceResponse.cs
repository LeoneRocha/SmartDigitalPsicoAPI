namespace SmartDigitalPsico.Domain.VO
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class ServiceResponse<T> : SmartDigitalPsico.Core.SDK.Domain.VO.ServiceResponse<T>, Interfaces.VO.IServiceResponse<T>
    {
    }
}
