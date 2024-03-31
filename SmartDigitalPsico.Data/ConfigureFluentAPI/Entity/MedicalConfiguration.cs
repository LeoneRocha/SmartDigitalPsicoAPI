﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.ConfigureFluentAPI.Entity
{
    public class MedicalConfiguration : IEntityTypeConfiguration<Medical>
    {
        public void Configure(EntityTypeBuilder<Medical> builder)
        {
            builder.ToTable("Medical", "dbo");
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Name).HasMaxLength(255).IsRequired().HasColumnType("varchar(255)");
            builder.Property(e => e.Email).HasMaxLength(100).IsRequired().HasColumnType("varchar(100)");
            builder.Property(e => e.Accreditation).HasMaxLength(20).IsRequired().HasColumnType("varchar(20)");
            builder.Property(e => e.SecurityKey).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(e => e.TypeAccreditation).HasConversion<byte>();
            // Relationship
            builder.HasOne(e => e.CreatedUser).WithMany(b => b.MedicalsCreateds).HasForeignKey(t => t.CreatedUserId).OnDelete(DeleteBehavior.NoAction).IsRequired(false);
            builder.HasOne(e => e.ModifyUser).WithMany(b => b.MedicalModifies).HasForeignKey(t => t.ModifyUserId).OnDelete(DeleteBehavior.NoAction).IsRequired(false);
            builder.HasOne(e => e.User).WithMany(b => b.MedicalsUsers).HasForeignKey(t => t.UserId).OnDelete(DeleteBehavior.Cascade).IsRequired(false);            
            builder.HasMany(e => e.Patienties).WithOne().HasForeignKey(e => e.MedicalId);              
            builder.HasMany(m => m.Specialties).WithMany(s => s.Medicals).UsingEntity(j => j.ToTable("MedicalSpecialty"));//MedicalSpecialties  
            
            builder.HasOne(e => e.Office).WithMany(b => b.Medicals).HasForeignKey(e => e.OfficeId);
        }
    }
} 
/*
builder.HasOne(e => e.User)
    .WithOne(i => i.Medical)
    .HasForeignKey<User>(b => b.MedicalId)
    .IsRequired(false)
    .OnDelete(DeleteBehavior.Cascade);          

builder
    .HasOne(m => m.User)
    .WithMany(u => u.Medicals)
    .HasForeignKey(m => m.UserId);
 */ 