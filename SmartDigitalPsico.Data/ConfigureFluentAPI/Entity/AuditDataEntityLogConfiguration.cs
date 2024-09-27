using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Constants;

namespace SmartDigitalPsico.Data.ConfigureFluentAPI.Entity
{
    public class AuditDataEntityLogConfiguration : IEntityTypeConfiguration<AuditDataEntityLog>
    {
        public void Configure(EntityTypeBuilder<AuditDataEntityLog> builder)
        {
            builder.ToTable("AuditDataEntityLog", "dbo");
            HelperCharSet.AddCharSet(builder);
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
                .HasColumnType(EntityTypeConfigurationConstants.Type_Text)
                .IsRequired();

            builder.Property(e => e.NewValues)
                .HasMaxLength(8000)
                .HasColumnType(EntityTypeConfigurationConstants.Type_Text)
                .IsRequired();

            builder.Property(e => e.AuditDate);

            builder.Property(e => e.UserAuditedLogin)
                .HasMaxLength(255)
                .IsRequired(false)
                .HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);

            // Relationship                                    
            builder.HasOne(e => e.UserAudited).WithMany().HasForeignKey(e => e.UserAuditedId);

            // Index
            builder.HasIndex(p => new { p.TableName, p.Operation })
                .IncludeProperties(p => new { p.AuditDate, p.UserAuditedId })
                .HasDatabaseName("Idx_TableName_Operation_Inc_AuditDate_UserAuditedId")
                .IsUnique(false);
        }
    }
}