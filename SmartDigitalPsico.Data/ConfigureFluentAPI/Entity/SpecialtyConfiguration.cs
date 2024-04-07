using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.ConfigureFluentAPI.Entity
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
            builder.Property(e => e.Description).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(e => e.Language).HasMaxLength(10).HasColumnType("varchar(10)");

            // Relationship
            //builder.HasMany(m => m.Medicals).WithMany(s => s.Specialties).UsingEntity(j => j.ToTable("MedicalSpecialty"));//MedicalSpecialties 
        }
    }
}