namespace SmartDigitalPsico.Domain.Interfaces.VO
{
    /// <summary>
    /// Shim Obsolete — use SmartDigitalPsico.Core.SDK.Domain.Interfaces.VO.IServiceResponse.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface IServiceResponse<T> : SmartDigitalPsico.Core.SDK.Domain.Interfaces.VO.IServiceResponse<T>
    {
    }
}
