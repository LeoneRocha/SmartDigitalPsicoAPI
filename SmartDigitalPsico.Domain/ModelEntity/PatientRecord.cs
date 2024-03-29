using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    [Table("PatientRecords", Schema = "dbo")]
    public class PatientRecord : EntityBase, IEntityBaseLogUser
    {
        #region Relationship  

        [Required]
        public Patient Patient { get; set; } = new Patient();

        [ForeignKey("PatientId")]
        public long PatientId { get; set; }

        public User? CreatedUser { get; set; }
        public User? ModifyUser { get; set; }

        [ForeignKey("CreatedUserId")]
        public long? CreatedUserId { get; set; }

        [ForeignKey("ModifyUserId")]
        public long? ModifyUserId { get; set; }
        #endregion Relationship

        #region Columns 

        [Column("Description", TypeName = "varchar(255)")]
        [MaxLength(255)]
        [Required]
        public string Description { get; set; } = string.Empty;

        [Column("Annotation")]
        [Required]
        public string Annotation { get; set; } = string.Empty;

        [Column("AnnotationDate")]
        public DateTime AnnotationDate { get; set; }

        #endregion Columns 
    }
}