﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Data.Context.Configure.Helper;
using SmartDigitalPsico.Data.Context.Configure.Mock;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class UserConfiguration : EntityBaseConfiguration<User>
    {
        public UserConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Name).HasMaxLength(255).IsRequired().HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.Email).HasMaxLength(100).IsRequired().HasColumnType("varchar(100)");
            builder.Property(e => e.Login).HasMaxLength(25).IsRequired().HasColumnType("varchar(25)");
            builder.Property(e => e.PasswordHash);
            builder.Property(e => e.PasswordSalt);
            builder.Property(e => e.Role).HasMaxLength(50).IsRequired().HasColumnType("varchar(50)");
            builder.Property(e => e.Admin);
            builder.Property(e => e.Language).HasMaxLength(10).HasColumnType("varchar(10)");
            builder.Property(e => e.TimeZone).HasMaxLength(255).HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.RefreshToken);
            builder.Property(e => e.RefreshTokenExpiryTime).HasColumnName("Refresh_token_expiry_time");

            // Relationship
            builder.HasOne(e => e.Medical).WithMany().HasForeignKey(e => e.MedicalId);
            builder.HasMany(e => e.MedicalsCreateds).WithOne(e => e.CreatedUser).HasForeignKey(e => e.CreatedUserId);
            builder.HasMany(e => e.MedicalModifies).WithOne(e => e.ModifyUser).HasForeignKey(e => e.ModifyUserId);
            builder.HasMany(e => e.MedicalsUsers).WithOne(e => e.User).HasForeignKey(e => e.UserId);

            builder.HasData(UserMockData.GetMock());
        }
    }
}