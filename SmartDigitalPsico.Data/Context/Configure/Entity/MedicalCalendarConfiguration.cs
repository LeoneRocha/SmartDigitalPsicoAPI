﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class MedicalCalendarConfiguration : EntityBaseConfiguration<MedicalCalendar>
    {
        public MedicalCalendarConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        public override void Configure(EntityTypeBuilder<MedicalCalendar> builder)
        {
            builder.ToTable("MedicalCalendar", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Title).HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(e => e.StartDate);
            builder.Property(e => e.EndDate);
            builder.Property(e => e.AllDay);
            builder.Property(e => e.Status).HasConversion<byte>();
            builder.Property(e => e.ColorCategory).HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(e => e.Url).HasMaxLength(150).HasColumnType("varchar(150)");
            builder.Property(e => e.PushedCalendar);
            builder.Property(e => e.TimeZone).HasMaxLength(150).HasColumnType("varchar(150)");

            // Relationship
            builder.HasOne(e => e.CreatedUser).WithMany().HasForeignKey(e => e.CreatedUserId);
            builder.HasOne(e => e.ModifyUser).WithMany().HasForeignKey(e => e.ModifyUserId);

            builder.HasOne(e => e.Medical).WithMany().HasForeignKey(e => e.MedicalId);
            builder.HasOne(e => e.Patient).WithMany().HasForeignKey(e => e.PatientId);
        }
    }
}