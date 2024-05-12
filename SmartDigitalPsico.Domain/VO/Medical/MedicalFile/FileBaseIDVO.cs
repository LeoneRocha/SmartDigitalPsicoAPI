using SmartDigitalPsico.Domain.VO.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.VO.Medical.MedicalFile
{
    public abstract class FileBaseIdVO : EntityVOBase
    {
        /// <summary>
        /// Name File
        /// </summary>
        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;

        [MaxLength(255)]
        public string FileName { get; set; } = string.Empty;

        [MaxLength(2083)]
        public string FilePath { get; set; } = string.Empty;

        public byte[] FileData { get; set; } =Array.Empty<byte>();  

        [MaxLength(3)]
        public string FileExtension { get; set; } = string.Empty;

        [MaxLength(100)]
        public string FileContentType { get; set; } = string.Empty;

        public long FileSizeKB { get; set; }
    }
}
