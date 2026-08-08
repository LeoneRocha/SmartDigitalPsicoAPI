namespace SmartDigitalPsico.Domain.Enuns
{
    /// <summary>
    /// Shim Obsolete — use SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeDataBase.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public enum ETypeDataBase
    {
        MSsqlServer = 0,
        Mysql = 1,
        Postgree = 3,
        FireBase = 4,
    }
}
