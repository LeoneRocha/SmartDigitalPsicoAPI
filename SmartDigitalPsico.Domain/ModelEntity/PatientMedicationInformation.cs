using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    [Table("PatientMedicationInformations", Schema = "dbo")]
    public class PatientMedicationInformation : EntityBaseSimple, IEntityBaseLogUser
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

        [Column("StartDate")]
        public DateTime StartDate { get; set; }

        [Column("EndDate")]
        public DateTime? EndDate { get; set; }

        [Column("Dosage", TypeName = "varchar(255)")]
        [MaxLength(255)]
        public string? Dosage { get; set; }

        [Column("Posology", TypeName = "varchar(255)")]
        [MaxLength(255)]
        public string? Posology { get; set; }

        /// <summary>
        /// F�rmaco
        /// </summary>
        [Column("MainDrug", TypeName = "varchar(255)")]
        [MaxLength(255)]
        public string? MainDrug { get; set; }



        #endregion Columns 
    }
}