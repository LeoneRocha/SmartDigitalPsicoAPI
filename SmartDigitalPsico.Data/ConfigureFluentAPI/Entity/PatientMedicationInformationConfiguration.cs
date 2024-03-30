﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.ConfigureFluentAPI.Entity
{
    public class PatientMedicationInformationConfiguration : IEntityTypeConfiguration<PatientMedicationInformation>
    {
        public void Configure(EntityTypeBuilder<PatientMedicationInformation> builder)
        {
            builder.ToTable("PatientMedicationInformation", "dbo");
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Description).HasMaxLength(255).IsRequired().HasColumnType("varchar(255)");
            builder.Property(e => e.StartDate);
            builder.Property(e => e.EndDate);
            builder.Property(e => e.Dosage).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(e => e.Posology).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(e => e.MainDrug).HasMaxLength(255).HasColumnType("varchar(255)");

            // Relationship            
            builder.HasOne(e => e.CreatedUser).WithMany().HasForeignKey(e => e.CreatedUserId);
            builder.HasOne(e => e.ModifyUser).WithMany().HasForeignKey(e => e.ModifyUserId);
            builder.HasOne(e => e.Patient).WithMany(p => p.PatientMedicationInformations).HasForeignKey(e => e.PatientId);
        }
    }
}