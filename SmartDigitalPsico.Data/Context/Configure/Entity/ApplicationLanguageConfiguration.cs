﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Data.Context.Configure.Helper;
using SmartDigitalPsico.Data.Context.Configure.Mock;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class ApplicationLanguageConfiguration : EntityBaseConfiguration<ApplicationLanguage>
    {
        public ApplicationLanguageConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        public override void Configure(EntityTypeBuilder<ApplicationLanguage> builder)
        {
            builder.ToTable("ApplicationLanguage", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Enable);
            builder.Property(c => c.Language).HasMaxLength(6);
            builder.Property(c => c.Description).HasMaxLength(255);
            builder.Property(c => c.LanguageKey).HasMaxLength(100);
            builder.Property(c => c.ResourceKey).HasMaxLength(100);
            builder.Property(c => c.LanguageValue).HasMaxLength(255);
            // Index
            builder.HasIndex(p => new { p.ResourceKey, p.Language, p.LanguageKey })
            .HasDatabaseName("Idx_ApplicationLanguage_ResourceKey_Language_LanguageKey_Unique")
            .IsUnique();

            builder.HasData(ApplicationLanguageMockData.GetMock());
        }
    }
}
