namespace SmartDigitalPsico.Domain.ModelEntity.Contracts
{

    /// <summary>
    /// Classe responsável por FileData.
    /// Responsabilidade: contrato compartilhado entre camadas.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class FileData : FileBase
    {
        public string FolderDestination { get; set; } = string.Empty;
    }
}
