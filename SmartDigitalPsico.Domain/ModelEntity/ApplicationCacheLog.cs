﻿using SmartDigitalPsico.Domain.Contracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    [Table("ApplicationCacheLogs", Schema = "dbo")]
    public class ApplicationCacheLog : EntityBase
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