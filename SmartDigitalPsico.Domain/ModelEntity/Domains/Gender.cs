using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Contracts.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDigitalPsico.Domain.ModelEntity.Domains
{
    [Table("Genders", Schema = "dbo")]
    public class Gender : EntityBaseSimple, IEntityBaseDomains
    {
        [Column("Description", TypeName = "varchar(50)")]
        [MaxLength(50)]
        public string Description { get; set; } = null!;//Ignore nullity

        [Column("Language", TypeName = "varchar(10)")]
        [MaxLength(10)]
        public string Language { get; set; }

    }
}