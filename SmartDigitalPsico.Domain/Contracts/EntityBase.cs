﻿using SmartDigitalPsico.Domain.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDigitalPsico.Domain.Contracts
{
    public abstract class EntityBase : IEntityBase, IEntityBaseLog
    { 
        [Column("Id", Order = 0)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Column("Enable", Order = 1)]
        [DefaultValue(true)]
        public bool Enable { get; set; }

        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [Column("ModifyDate")]
        public DateTime ModifyDate { get; set; }

        [Column("LastAccessDate")]
        public DateTime LastAccessDate { get; set; }
    }
}
