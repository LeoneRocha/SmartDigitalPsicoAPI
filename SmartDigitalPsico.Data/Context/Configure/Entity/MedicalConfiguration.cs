﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class MedicalConfiguration : EntityBaseConfiguration<Medical>
    {
        public override void Configure(EntityTypeBuilder<Medical> builder)
        {
            builder.ToTable("Medical", "dbo");
            HelperCharSet.AddCharSet(builder);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Name).HasMaxLength(255).IsRequired().HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.Email).HasMaxLength(100).IsRequired().HasColumnType("varchar(100)");
            builder.Property(e => e.Accreditation).HasMaxLength(20).IsRequired().HasColumnType("varchar(20)");
            builder.Property(e => e.SecurityKey).HasMaxLength(255).HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.TypeAccreditation).HasConversion<byte>();
            // Relationship
            builder.HasOne(e => e.CreatedUser).WithMany(b => b.MedicalsCreateds).HasForeignKey(t => t.CreatedUserId).OnDelete(DeleteBehavior.NoAction).IsRequired(false);
            builder.HasOne(e => e.ModifyUser).WithMany(b => b.MedicalModifies).HasForeignKey(t => t.ModifyUserId).OnDelete(DeleteBehavior.NoAction).IsRequired(false);
            builder.HasOne(e => e.User).WithMany(b => b.MedicalsUsers).HasForeignKey(t => t.UserId).OnDelete(DeleteBehavior.Cascade).IsRequired(false);
            builder.HasOne(e => e.Office).WithMany(b => b.Medicals).HasForeignKey(e => e.OfficeId);
            builder.HasMany(e => e.Patienties).WithOne().HasForeignKey(e => e.MedicalId);
        }
    }
}