namespace SmartDigitalPsico.Domain.Enuns
{
    /// <summary>
    /// Enumeração Obsolete — use SmartDigitalPsico.Core.SDK.Domain.Enuns.EStorageAdapterType.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_REPO")]
    public enum EStorageAdapterType
    {
        Azure = 0,
        AWS = 1,
        Google = 2,
    }
}
