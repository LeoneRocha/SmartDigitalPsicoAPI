using SmartDigitalPsico.Domain.Contracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDigitalPsico.Domain.ModelEntity.Domains.Configurations
{
    [Table("ApplicationCacheLogs", Schema = "dbo")]
    public class ApplicationCacheLog : EntityBaseSimple
    {

        public DateTime DateTimeSlidingExpiration { get; set; }

        [Column("CacheId", TypeName = "varchar(255)")]
        [MaxLength(255)]
        public string CacheId { get; set; }


        [Column("CacheKey", TypeName = "varchar(255)")]
        [MaxLength(255)]
        public string CacheKey { get; set; }

    }
}