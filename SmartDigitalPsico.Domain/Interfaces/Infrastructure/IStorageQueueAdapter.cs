namespace SmartDigitalPsico.Domain.Interfaces.Infrastructure
{
    /// <summary>
    /// Shim Obsolete — use SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure.IStorageQueueContract.
    /// </summary>
    // Movido para SmartDigitalPsicoAPI.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_REPO")]
    public interface IStorageQueueContract : SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure.IStorageQueueContract
    {
    }
}
