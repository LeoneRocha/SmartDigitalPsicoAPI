namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalFile
{
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
