namespace SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts
{
    /// <summary>
    /// Classe responsável por FileData.
    /// Responsabilidade: contrato compartilhado entre camadas.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class FileData : FileBase
    {
        public string FolderDestination { get; set; } = string.Empty;
    }
}
