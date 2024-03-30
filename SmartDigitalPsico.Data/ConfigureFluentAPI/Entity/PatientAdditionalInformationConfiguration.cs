using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.ConfigureFluentAPI.Entity
{
    public class PatientAdditionalInformationConfiguration : IEntityTypeConfiguration<PatientAdditionalInformation>
    {
        public void Configure(EntityTypeBuilder<PatientAdditionalInformation> builder)
        {
            builder.ToTable("PatientAdditionalInformations", "dbo");
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.FollowUp_Psychiatric).HasMaxLength(2000).HasColumnType("varchar(2000)");
            builder.Property(e => e.FollowUp_Neurological).HasMaxLength(2000).HasColumnType("varchar(2000)");
            // Relationship
            builder.HasOne(e => e.Patient).WithMany().HasForeignKey(e => e.PatientId);
            builder.HasOne(e => e.CreatedUser).WithMany().HasForeignKey(e => e.CreatedUserId);
            builder.HasOne(e => e.ModifyUser).WithMany().HasForeignKey(e => e.ModifyUserId);             
            
            builder.HasOne(e => e.Patient).WithMany(p => p.PatientAdditionalInformations).HasForeignKey(e => e.PatientId); 
        }
    }
}
