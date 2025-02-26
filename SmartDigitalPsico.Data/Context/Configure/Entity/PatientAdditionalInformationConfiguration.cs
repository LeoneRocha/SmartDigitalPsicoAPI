using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Data.Context.Configure.Helper;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class PatientAdditionalInformationConfiguration : EntityBaseConfiguration<PatientAdditionalInformation>
    {
        public PatientAdditionalInformationConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        public override void Configure(EntityTypeBuilder<PatientAdditionalInformation> builder)
        {  
            builder.ToTable("PatientAdditionalInformation", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
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
