using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Medical.MedicalFile
{
    public abstract class FileBaseVO
    {
        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;

        [MaxLength(2083)]
        public string FilePath { get; set; } = string.Empty;

        public byte[] FileData { get; set; } = Array.Empty<byte>(); 

        public string FileData64 { get; set; } = string.Empty;
         
        [MaxLength(3)]
        public string FileExtension { get; set; } = string.Empty;

        [MaxLength(100)]
        public string FileContentType { get; set; } = string.Empty;

        public long FileSizeKB { get; set; }
    }
}
