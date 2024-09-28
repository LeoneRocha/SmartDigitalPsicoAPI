using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class PatientHospitalizationInformationConfiguration : EntityBaseConfiguration<PatientHospitalizationInformation>
    {
        public override void Configure(EntityTypeBuilder<PatientHospitalizationInformation> builder)
        {
            builder.ToTable("PatientHospitalizationInformation", "dbo");
            HelperCharSet.AddCharSet(builder);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Description).HasMaxLength(255).IsRequired().HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.StartDate);
            builder.Property(e => e.EndDate);
            builder.Property(e => e.CID).HasMaxLength(20).IsRequired().HasColumnType("varchar(20)");
            builder.Property(e => e.Observation).HasMaxLength(2000).IsRequired().HasColumnType("varchar(2000)");
            // Relationship            
            builder.HasOne(e => e.CreatedUser).WithMany().HasForeignKey(e => e.CreatedUserId);
            builder.HasOne(e => e.ModifyUser).WithMany().HasForeignKey(e => e.ModifyUserId);
            builder.HasOne(e => e.Patient).WithMany(p => p.PatientHospitalizationInformations).HasForeignKey(e => e.PatientId);
        }
    }
}