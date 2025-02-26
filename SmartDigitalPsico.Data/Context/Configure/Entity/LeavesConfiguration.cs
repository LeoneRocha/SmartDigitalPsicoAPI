using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Data.Context.Configure.Helper;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class LeavesConfiguration : EntityBaseConfiguration<Leaves>
    {
        public LeavesConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }

        public override void Configure(EntityTypeBuilder<Leaves> builder)
        {
            builder.ToTable("Leaves", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);

            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.MedicalId).IsRequired(false);
            builder.Property(e => e.StartDate).IsRequired();
            builder.Property(e => e.EndDate).IsRequired(false);
            builder.Property(e => e.Description).HasMaxLength(255).IsRequired();
            builder.Property(e => e.Language).HasMaxLength(10).IsRequired();
            builder.Property(e => e.IsRecurring).IsRequired();

            // Indexes (using Fluent API)
            builder.HasIndex(e => e.MedicalId).HasDatabaseName("IX_Leaves_MedicalId");
            builder.HasIndex(e => new { e.StartDate, e.EndDate }).HasDatabaseName("IX_Leaves_StartDate_EndDate");
        }
    }
}
