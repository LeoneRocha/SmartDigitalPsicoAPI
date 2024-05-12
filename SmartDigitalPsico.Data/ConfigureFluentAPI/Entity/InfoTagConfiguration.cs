using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Constants;

namespace SmartDigitalPsico.Data.ConfigureFluentAPI.Entity
{
    public class InfoTagConfiguration : IEntityTypeConfiguration<InfoTag>
    {
        public void Configure(EntityTypeBuilder<InfoTag> builder)
        {
            builder.ToTable("InfoTag", "dbo");
            HelperCharSet.AddCharSet(builder);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Tag).HasMaxLength(255).IsRequired().HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);

            // Relationship
            builder.HasOne(e => e.CreatedUser).WithMany().HasForeignKey(e => e.CreatedUserId);
            builder.HasOne(e => e.ModifyUser).WithMany().HasForeignKey(e => e.ModifyUserId);
            
            builder.HasOne(e => e.Medical).WithMany().HasForeignKey(e => e.MedicalId);
            builder.HasMany(e => e.PatientInfoTags).WithOne();
        }
    }
}
