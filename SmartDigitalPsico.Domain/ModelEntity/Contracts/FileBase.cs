using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Contracts;
using EntityBase = SmartDigitalPsicoAPI.Core.SDK.Domain.Contracts.EntityBase;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SmartDigitalPsico.Domain.ModelEntity.Contracts
{
    /// <summary>
    /// Classe responsável por FileBase.
    /// Responsabilidade: contrato compartilhado entre camadas.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public abstract class FileBase : EntityBase
    {
        #region Columns  
        /// <summary>
        /// Name File
        /// </summary>
        [Column("Description", TypeName = "varchar(255)")]
        [MaxLength(255)]
        public string Description { get; set; } = string.Empty;

        [Column("FileName", TypeName = "varchar(255)")]
        [MaxLength(255)]
        public string FileName { get; set; } = string.Empty;

        [Column("FilePath", TypeName = "varchar(2083)")]
        [MaxLength(2083)]
        public string FilePath { get; set; } = string.Empty;

        [Column("FileData")]
        public byte[] FileData { get; set; } = [];

        [Column("FileExtension", TypeName = "varchar(3)")]
        [MaxLength(3)]
        public string FileExtension { get; set; } = string.Empty;

        [Column("FileContentType", TypeName = "varchar(100)")]
        [MaxLength(100)]
        public string FileContentType { get; set; } = string.Empty;

        [Column("FileSizeKB")]
        public long FileSizeKB { get; set; }

        [Column("TypeLocationSaveFile")]
        public SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns.ETypeLocationSaveFiles TypeLocationSaveFile { get; set; }


        [Column("FileCloudContainer", TypeName = "varchar(60)")]
        [MaxLength(60)]
        public string FileCloudContainer { get; set; } = string.Empty;
        [Column("FileBlobName", TypeName = "varchar(255)")]
        [MaxLength(255)]
        public string FileBlobName { get; set; } = string.Empty;

        #endregion Columns 
    }
}
