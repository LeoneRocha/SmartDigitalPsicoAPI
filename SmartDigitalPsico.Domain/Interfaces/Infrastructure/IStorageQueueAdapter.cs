namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure
{
    /// <summary>
    /// Shim Obsolete — use SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageQueueContract.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_REPO")]
    public interface IStorageQueueContract : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure.IStorageQueueContract
    {
    }
}
