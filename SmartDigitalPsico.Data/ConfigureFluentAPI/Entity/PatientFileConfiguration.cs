﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Constants;

namespace SmartDigitalPsico.Data.ConfigureFluentAPI.Entity
{
    public class PatientFileConfiguration : IEntityTypeConfiguration<PatientFile>
    {
        public void Configure(EntityTypeBuilder<PatientFile> builder)
        {
            builder.ToTable("PatientFile", "dbo");
            HelperCharSet.AddCharSet(builder);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Description).HasMaxLength(255).HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.FileName).HasMaxLength(255).HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.FilePath).HasMaxLength(2083).HasColumnType("varchar(2083)");
            builder.Property(e => e.FileData);
            builder.Property(e => e.FileExtension).HasMaxLength(3).HasColumnType("varchar(3)");
            builder.Property(e => e.FileContentType).HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(e => e.FileSizeKB);
            builder.Property(e => e.TypeLocationSaveFile).HasConversion<byte>();

            // Relationship
            builder.HasOne(e => e.CreatedUser).WithMany().HasForeignKey(e => e.CreatedUserId);
            builder.HasOne(e => e.ModifyUser).WithMany().HasForeignKey(e => e.ModifyUserId);
            
            builder.HasOne(e => e.Patient).WithMany().HasForeignKey(e => e.PatientId);
        }
    }
}