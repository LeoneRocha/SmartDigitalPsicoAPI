using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.ConfigureFluentAPI.Entity
{
    public class PatientInfoTagConfiguration : IEntityTypeConfiguration<PatientInfoTag>
    {
        public void Configure(EntityTypeBuilder<PatientInfoTag> builder)
        {
            builder.ToTable("PatientInfoTag", "dbo");
            builder.HasKey(e => new { e.InfoTagId, e.PatientId });
            // Properties
            builder.Property(e => e.InfoTagId);
            builder.Property(e => e.PatientId);

            // Relationship
            builder.HasOne(e => e.InfoTag).WithMany(p => p.PatientInfoTags).HasForeignKey(e => e.InfoTagId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.Patient).WithMany(p => p.PatientInfoTags).HasForeignKey(e => e.PatientId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
