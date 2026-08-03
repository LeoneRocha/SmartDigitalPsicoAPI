namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalFile
{
    /// <summary>
    /// Classe responsável por FileBaseDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public abstract class FileBaseDto
    { 
        public string Description { get; set; } = string.Empty; 
        public string FilePath { get; set; } = string.Empty;
        public byte[] FileData { get; set; } = Array.Empty<byte>(); 
        public string FileData64 { get; set; } = string.Empty;          
        public string FileExtension { get; set; } = string.Empty;         
        public string FileContentType { get; set; } = string.Empty;
        public long FileSizeKB { get; set; }
    }
}
