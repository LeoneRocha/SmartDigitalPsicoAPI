using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.ConfigureFluentAPI.Entity
{
    public class InfoTagConfiguration : IEntityTypeConfiguration<InfoTag>
    {
        public void Configure(EntityTypeBuilder<InfoTag> builder)
        {
            builder.ToTable("InfoTag", "dbo");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Tag).HasMaxLength(255).IsRequired().HasColumnType("varchar(255)");

            // Relationship
            builder.HasOne(e => e.Medical)
                .WithMany()
                .HasForeignKey(e => e.MedicalId);

            builder.HasOne(e => e.CreatedUser)
                .WithMany()
                .HasForeignKey(e => e.CreatedUserId);

            builder.HasOne(e => e.ModifyUser)
                .WithMany()
                .HasForeignKey(e => e.ModifyUserId);

            builder.HasMany(e => e.PatientInfoTags)
                .WithOne();

        }
    }

}
