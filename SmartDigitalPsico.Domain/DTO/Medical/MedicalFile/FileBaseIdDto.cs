using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalFile
{
    /// <summary>
    /// Classe responsável por FileBaseIdDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public abstract class FileBaseIdDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBase
    { 
        public string Description { get; set; } = string.Empty;         
        public string FileName { get; set; } = string.Empty;         
        public string FilePath { get; set; } = string.Empty;
        public byte[] FileData { get; set; } = Array.Empty<byte>();         
        public string FileExtension { get; set; } = string.Empty;         
        public string FileContentType { get; set; } = string.Empty;
        public long FileSizeKB { get; set; }
    }
}
