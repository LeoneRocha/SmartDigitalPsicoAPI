﻿using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Contracts.Interface;
using SmartDigitalPsico.Domain.ModelEntity.Principals;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDigitalPsico.Domain.ModelEntity.Domains
{
    [Table("RoleGroups", Schema = "dbo")]
    public class RoleGroup : EntityBaseSimple, IEntityBaseDomains
    {
        public List<User> Users { get; set; }

        [Column("Description", TypeName = "varchar(50)")]
        [MaxLength(50)]
        public string Description { get; set; }

        [Column("Language", TypeName = "varchar(10)")]
        [MaxLength(10)]
        public string Language { get; set; }

        [Column("RolePolicyClaimCode", TypeName = "varchar(25)")]
        [MaxLength(25)]
        public string RolePolicyClaimCode { get; set; }
    }
}