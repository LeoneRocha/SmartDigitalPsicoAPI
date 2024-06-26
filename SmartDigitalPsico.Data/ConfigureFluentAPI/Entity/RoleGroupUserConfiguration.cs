﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.ConfigureFluentAPI.Entity
{
    public class RoleGroupUserConfiguration : IEntityTypeConfiguration<RoleGroupUser>
    {
        public void Configure(EntityTypeBuilder<RoleGroupUser> builder)
        {
            builder.ToTable("RoleGroupUser", "dbo");
            HelperCharSet.AddCharSet(builder);
            builder.HasKey(e => new { e.UserId, e.RoleGroupId });
            // Properties
            builder.Property(e => e.UserId);
            builder.Property(e => e.RoleGroupId);

            // Relationship
            builder.HasOne(e => e.User).WithMany(p => p.UserRoleGroups).HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.RoleGroup).WithMany(p => p.UserRoleGroups).HasForeignKey(e => e.RoleGroupId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
