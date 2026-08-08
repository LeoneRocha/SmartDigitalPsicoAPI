namespace SmartDigitalPsico.Domain.ModelEntity.Contracts
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// Host FileData inherits host FileBase so product `FileData : FileBase` identity is preserved;
    /// FolderDestination mirrors Core.FileData.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class FileData : FileBase
    {
        public string FolderDestination { get; set; } = string.Empty;
    }
}
