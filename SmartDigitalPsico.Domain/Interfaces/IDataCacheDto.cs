namespace SmartDigitalPsico.Domain.Interfaces
{
    /// <summary>
    /// Shim Obsolete — use SmartDigitalPsico.Core.SDK.Domain.Interfaces.IDataCacheDto.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface IDataCacheDto<T> : SmartDigitalPsico.Core.SDK.Domain.Interfaces.IDataCacheDto<T>
    {
    }
}
