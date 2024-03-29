using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    [Table("PatientNotificationMessage", Schema = "dbo")]
    public class PatientNotificationMessage : EntityBase, IEntityBaseLogUser
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
        [Column("MessagePatient", TypeName = "varchar(2000)")]
        [MaxLength(2000)]
        [Required]
        public string MessagePatient { get; set; } = string.Empty;

        [Column("IsReaded")]
        public bool IsReaded { get; set; }

        [Column("ReadingDate")]
        public DateTime? ReadingDate { get; set; }

        [Column("Notified")]
        public bool Notified { get; set; }

        [Column("NotifiedDate")]
        public DateTime? NotifiedDate { get; set; }

        #endregion Columns 
    }
}