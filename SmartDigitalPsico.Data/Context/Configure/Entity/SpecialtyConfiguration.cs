﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Data.Context.Configure.Helper;
using SmartDigitalPsico.Data.Context.Configure.Mock;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class SpecialtyConfiguration : EntityBaseConfiguration<Specialty>
    {
        public SpecialtyConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        public override void Configure(EntityTypeBuilder<Specialty> builder)
        {
            builder.ToTable("Specialty", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Description).HasMaxLength(255).HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.Language).HasMaxLength(10).HasColumnType("varchar(10)");

            builder.HasData(SpecialtyMockData.GetMock());
        }
    }
}