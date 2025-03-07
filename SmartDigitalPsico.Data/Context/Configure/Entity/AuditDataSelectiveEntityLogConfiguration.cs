﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Data.Context.Configure.Helper;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class AuditDataSelectiveEntityLogConfiguration : EntityBaseConfiguration<AuditDataSelectiveEntityLog>
    {
        public AuditDataSelectiveEntityLogConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        public override void Configure(EntityTypeBuilder<AuditDataSelectiveEntityLog> builder)
        {
            builder.ToTable("AuditDataSelectiveEntityLog", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.TableName)
                .HasMaxLength(255)
                .IsRequired()
                .HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);

            builder.Property(e => e.Operation)
                .HasMaxLength(20)
                .IsRequired()
                .HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_20);

            builder.Property(e => e.KeyValue)
                .HasMaxLength(255)
                .HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255)
                .IsRequired();

            builder.Property(e => e.OldValues)
                .HasMaxLength(8000)
                .HasColumnType(EntityTypeConfigurationConstants.GetTypeTextByTypeDataBase(ETypeDataBase))
                .IsRequired();

            builder.Property(e => e.NewValues)
                .HasMaxLength(8000)
                .HasColumnType(EntityTypeConfigurationConstants.GetTypeTextByTypeDataBase(ETypeDataBase))
                .IsRequired();

            builder.Property(e => e.AuditDate);

            builder.Property(e => e.UserAuditedLogin)
                .HasMaxLength(255)
                .IsRequired(false)
                .HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);

            builder.Property(e => e.RowKey)
                .HasMaxLength(40)
                .HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_40)
                .IsRequired(false);

            builder.Property(e => e.PartitionKey)
                .HasMaxLength(40)
                .HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_40)
                .IsRequired(false);

            // Relationship                                    
            builder.HasOne(e => e.UserAudited).WithMany().HasForeignKey(e => e.UserAuditedId);

            // Index
            builder.HasIndex(p => new { p.TableName, p.Operation })
                .IncludeProperties(p => new { p.AuditDate, p.UserAuditedId })
                .HasDatabaseName("Idx_TableName_Operation_Inc_AuditDate_UserAuditedId")
                .IsUnique(false);


            if (ETypeDataBase == ETypeDataBase.Mysql)
            {
                // Index FOR MYSQL  
                builder.HasIndex(p => new { p.TableName, p.Operation, p.AuditDate, p.UserAuditedId })                   
                   .HasDatabaseName("Idx_TableName_Operation_AuditDate_UserAuditedId")
                   .IsUnique(false);
            }

        }
    }
}