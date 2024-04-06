using SmartDigitalPsico.Domain.VO.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Medical.MedicalFile
{
    public abstract class FileBaseIDVO : EntityVOBase
    {
        /// <summary>
        /// Name File
        /// </summary>
        [MaxLength(255)]
        public string? Description { get; set; }

        [MaxLength(255)]
        public string? FileName { get; set; }

        [MaxLength(2083)]
        public string? FilePath { get; set; }

        public byte[]? FileData { get; set; }

        [MaxLength(3)]
        public string? FileExtension { get; set; }

        [MaxLength(100)]
        public string? FileContentType { get; set; }

        public long FileSizeKB { get; set; }
    }
}
