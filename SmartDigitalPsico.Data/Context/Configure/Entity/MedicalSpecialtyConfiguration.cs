using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Data.Context.Configure.Mock;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class MedicalSpecialtyConfiguration : EntityBaseConfiguration<MedicalSpecialty>
    {
        public MedicalSpecialtyConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        public override void Configure(EntityTypeBuilder<MedicalSpecialty> builder)
        {
            builder.ToTable("MedicalSpecialty", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => new { e.MedicalId, e.SpecialtyId });
            // Properties
            builder.Property(e => e.MedicalId);
            builder.Property(e => e.SpecialtyId);

            // Relationship
            builder.HasOne(e => e.Medical).WithMany(p => p.MedicalSpecialties).HasForeignKey(e => e.MedicalId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.Specialty).WithMany(p => p.MedicalSpecialties).HasForeignKey(e => e.SpecialtyId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(MedicalSpecialtyMockData.GetMock());
        }
    }
}
