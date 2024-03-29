using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    [Table("Genders", Schema = "dbo")]
    public class Gender : EntityBase, IEntityBaseDomains
    {
        [Column("Description", TypeName = "varchar(50)")]
        [MaxLength(50)]
        public string Description { get; set; } = null!; 

        [Column("Language", TypeName = "varchar(10)")]
        [MaxLength(10)]
        public string Language { get; set; }

    }
}