using SmartDigitalPsico.Domain.Contracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    [Table("Users", Schema = "dbo")]
    public class User : EntityBase
    {

        #region Relationship
        public List<RoleGroup> RoleGroups { get; set; } = new List<RoleGroup>();

        public List<Medical> MedicalsCreateds { get; set; } = new List<Medical>();

        public List<Medical> MedicalModifies { get; set; } = new List<Medical>();

        public List<Medical> MedicalsUsers { get; set; } = new List<Medical>();

        public Medical? Medical { get; set; }
        public long? MedicalId { get; set; }

        #endregion Relationship

        #region Columns 

        [Column("Login", Order = 4, TypeName = "varchar(25)")]
        [MaxLength(25)]
        [Required]
        public string Login { get; set; } = string.Empty;

        [Column("PasswordHash")]
        public byte[] PasswordHash { get; set; } = [];
        [Column("PasswordSalt")]
        public byte[] PasswordSalt { get; set; } = [];

        [Required]
        [Column("Role", TypeName = "varchar(50)")]
        [MaxLength(50)]

        public string Role { get; set; }

        public bool Admin { get; set; }

        [Column("Language", TypeName = "varchar(10)")]
        [MaxLength(10)]
        public string? Language { get; set; }

        [Column("TimeZone", TypeName = "varchar(255)")]
        [MaxLength(255)]
        public string? TimeZone { get; set; }

        [Column("Refresh_token")]
        public string? RefreshToken { get; set; }

        [Column("Refresh_token_expiry_time")]
        public DateTime? RefreshTokenExpiryTime { get; set; }

        #endregion Columns 
    }
}