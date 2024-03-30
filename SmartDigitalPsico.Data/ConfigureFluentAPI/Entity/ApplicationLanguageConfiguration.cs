﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.ConfigureFluentAPI.Entity
{
    public class ApplicationLanguageConfiguration : IEntityTypeConfiguration<ApplicationLanguage>
    {
        public void Configure(EntityTypeBuilder<ApplicationLanguage> builder)
        {
            builder.ToTable("ApplicationLanguage", "dbo");
            builder.HasKey(e => e.Id);
            // Required
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Enable);
            builder.Property(c => c.Language).HasMaxLength(10);
            builder.Property(c => c.Description).HasMaxLength(255);
            builder.Property(c => c.LanguageKey).HasMaxLength(255);
            builder.Property(c => c.ResourceKey).HasMaxLength(255);
            builder.Property(c => c.LanguageValue).HasMaxLength(1000);

            builder.HasIndex(p => new { p.ResourceKey, p.Language, p.LanguageKey })
            .HasDatabaseName("Idx_ApplicationLanguage_ResourceKey_Language_LanguageKey_Unique")
            .IsUnique();
        }
    }
}
