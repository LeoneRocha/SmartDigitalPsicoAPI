using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Medical.MedicalFile
{
    public abstract class FileBaseVO
    {
        [MaxLength(255)]
        public string? Description { get; set; }

        [MaxLength(2083)]
        public string? FilePath { get; set; }

        public byte[]? FileData { get; set; }

        public string? FileData64 { get; set; }


        [MaxLength(3)]
        public string? FileExtension { get; set; }

        [MaxLength(100)]
        public string? FileContentType { get; set; }

        public long? FileSizeKB { get; set; }
    }
}
