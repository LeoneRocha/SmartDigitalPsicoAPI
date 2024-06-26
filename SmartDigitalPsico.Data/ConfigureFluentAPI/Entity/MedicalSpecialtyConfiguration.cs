﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.ConfigureFluentAPI.Entity
{
    public class MedicalSpecialtyConfiguration : IEntityTypeConfiguration<MedicalSpecialty>
    {
        public void Configure(EntityTypeBuilder<MedicalSpecialty> builder)
        {
            builder.ToTable("MedicalSpecialty", "dbo");
            HelperCharSet.AddCharSet(builder);
            builder.HasKey(e => new { e.MedicalId, e.SpecialtyId });
            // Properties
            builder.Property(e => e.MedicalId);
            builder.Property(e => e.SpecialtyId);

            // Relationship
            builder.HasOne(e => e.Medical).WithMany(p => p.MedicalSpecialties).HasForeignKey(e => e.MedicalId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.Specialty).WithMany(p => p.MedicalSpecialties).HasForeignKey(e => e.SpecialtyId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
