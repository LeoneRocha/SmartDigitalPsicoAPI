using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class PatientInfoTagConfiguration : EntityBaseConfiguration<PatientInfoTag>
    {
        public PatientInfoTagConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        public override void Configure(EntityTypeBuilder<PatientInfoTag> builder)
        {
            builder.ToTable("PatientInfoTag", "dbo");
            HelperCharSet.AddCharSet(builder);
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
