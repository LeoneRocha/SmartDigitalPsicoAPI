using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Contracts.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDigitalPsico.Domain.ModelEntity.Principals
{
    [Table("PatientHospitalizationInformations", Schema = "dbo")]
    public class PatientHospitalizationInformation : EntityBaseSimple, IEntityBaseLogUser
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

        [Column("CID", TypeName = "varchar(20)")]
        [MaxLength(20)]
        [Required]
        public string CID { get; set; }

        [Column("Observation", TypeName = "varchar(2000)")]
        [MaxLength(2000)]
        [Required]
        public string Observation { get; set; } = string.Empty;


        #endregion Columns 
    }
}