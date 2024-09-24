using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalFile
{
    public abstract class FileBaseIdDto : EntityDtoBase
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