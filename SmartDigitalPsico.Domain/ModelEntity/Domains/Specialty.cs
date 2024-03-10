using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Contracts.Interface;
using SmartDigitalPsico.Domain.ModelEntity.Principals;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDigitalPsico.Domain.ModelEntity.Domains
{
    [Table("Specialties", Schema = "dbo")]
    public class Specialty : EntityBaseSimple, IEntityBaseDomains
    {
        [Column("Description", TypeName = "varchar(255)")]
        [MaxLength(255)]
        public string Description { get; set; }

        [Column("Language", TypeName = "varchar(10)")]
        [MaxLength(10)]
        public string Language { get; set; }

        public List<Medical> Medicals { get; set; }
    }
}