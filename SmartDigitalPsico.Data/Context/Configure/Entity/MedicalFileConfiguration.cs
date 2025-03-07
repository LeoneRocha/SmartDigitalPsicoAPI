﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Data.Context.Configure.Helper;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class MedicalFileConfiguration : EntityBaseConfiguration<MedicalFile>
    {
        public MedicalFileConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        public override void Configure(EntityTypeBuilder<MedicalFile> builder)
        {
            builder.ToTable("MedicalFile", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
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

            builder.Property(e => e.FileCloudContainer).HasMaxLength(60).HasColumnType("varchar(60)");
            builder.Property(e => e.FileBlobName).HasMaxLength(255).HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);

            // Relationship
            builder.HasOne(e => e.CreatedUser).WithMany().HasForeignKey(e => e.CreatedUserId);
            builder.HasOne(e => e.ModifyUser).WithMany().HasForeignKey(e => e.ModifyUserId);

            builder.HasOne(e => e.Medical).WithMany().HasForeignKey(e => e.MedicalId);
        }
    }
}