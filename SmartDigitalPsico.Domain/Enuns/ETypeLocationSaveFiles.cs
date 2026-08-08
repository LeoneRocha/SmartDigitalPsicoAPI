using System.ComponentModel;

namespace SmartDigitalPsico.Domain.Enuns
{
    /// <summary>
    /// Shim Obsolete — use SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public enum ETypeLocationSaveFiles
    {
        [Description("Local Salvamento em Banco de dados")]
        DataBase = 0,

        [Description("Local Salvamento em Disco HD/SSD")]
        Disk = 1,

        [Description("Local Salvamento em Cloud Storage Azure")]
        CloudStorageAzure = 2,

        [Description("Local Salvamento em Cloud Storage AWS")]
        CloudStorageAWS = 3,
    }
}
