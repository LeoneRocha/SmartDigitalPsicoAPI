using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class SpecialtyConfiguration : IEntityTypeConfiguration<Specialty>
    {
        public void Configure(EntityTypeBuilder<Specialty> builder)
        {
            builder.ToTable("Specialty", "dbo");
            HelperCharSet.AddCharSet(builder);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Description).HasMaxLength(255).HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.Language).HasMaxLength(10).HasColumnType("varchar(10)");
        }
    }
}