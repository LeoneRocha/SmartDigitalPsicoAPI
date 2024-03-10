using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Contracts.Interface;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity.Domains;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDigitalPsico.Domain.ModelEntity.Principals
{
    [Table("Medicals", Schema = "dbo")]
    public class Medical : EntityBase, IEntityBaseLogUser
    {
        #region Relationship
        [ForeignKey("OfficeId")]
        public long OfficeId { get; set; }

        public Office Office { get; set; }

        public User? User { get; set; }
        public long? UserId { get; set; }

        public List<Specialty> Specialties { get; set; }

        public List<Patient> Patienties { get; set; }

        public User? CreatedUser { get; set; }
        public long? CreatedUserId { get; set; }

        public User? ModifyUser { get; set; }
        public long? ModifyUserId { get; set; }

        #endregion Relationship

        #region Columns

        [Column("Accreditation", TypeName = "varchar(20)")]
        [MaxLength(20)]
        [Required]
        public string Accreditation { get; set; } = string.Empty;

        [Column("TypeAccreditation")]
        public ETypeAccreditation TypeAccreditation { get; set; }

        [Column("SecurityKey", TypeName = "varchar(255)")]
        [MaxLength(255)]
        public string? SecurityKey { get; set; }

        #endregion Columns 
    }
}