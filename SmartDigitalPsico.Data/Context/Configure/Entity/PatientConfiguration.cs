using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class PatientConfiguration : EntityBaseConfiguration<Patient>
    {
        public PatientConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        public override void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("Patient", "dbo");
            HelperCharSet.AddCharSet(builder);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Name).HasMaxLength(255).IsRequired().HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.Email).HasMaxLength(100).IsRequired().HasColumnType("varchar(100)");
            builder.Property(e => e.DateOfBirth);
            builder.Property(e => e.Profession).HasMaxLength(255).HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.Cpf).HasMaxLength(15).HasColumnType("varchar(15)");
            builder.Property(e => e.Rg).HasMaxLength(15).IsRequired().HasColumnType("varchar(15)");
            builder.Property(e => e.Education).HasMaxLength(255).HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.MaritalStatus).HasConversion<byte>();
            builder.Property(e => e.PhoneNumber).HasMaxLength(20).HasColumnType("varchar(20)");
            builder.Property(e => e.AddressStreet).HasMaxLength(255).HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.AddressNeighborhood).HasMaxLength(255).HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.AddressCity).HasMaxLength(255).HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.AddressState).HasMaxLength(255).HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.AddressCep).HasMaxLength(20).HasColumnType("varchar(20)");
            builder.Property(e => e.EmergencyContactName).HasMaxLength(255).HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.EmergencyContactPhoneNumber).HasMaxLength(20).HasColumnType("varchar(20)");

            // Relationship                        
            builder.HasOne(e => e.Gender).WithMany(b => b.Patients).HasForeignKey(e => e.GenderId);
            builder.HasOne(e => e.CreatedUser).WithMany().HasForeignKey(e => e.CreatedUserId);
            builder.HasOne(e => e.ModifyUser).WithMany().HasForeignKey(e => e.ModifyUserId);
            builder.HasOne(e => e.Medical).WithMany(m => m.Patienties).HasForeignKey(e => e.MedicalId);
            builder.HasMany(e => e.PatientAdditionalInformations).WithOne(p => p.Patient).HasForeignKey(p => p.PatientId);
            builder.HasMany(e => e.PatientHospitalizationInformations).WithOne(p => p.Patient).HasForeignKey(p => p.PatientId);
            builder.HasMany(e => e.PatientMedicationInformations).WithOne(p => p.Patient).HasForeignKey(p => p.PatientId);
            builder.HasMany(e => e.PatientRecords).WithOne(p => p.Patient).HasForeignKey(p => p.PatientId);
            builder.HasMany(e => e.PatientInfoTags).WithOne(p => p.Patient).HasForeignKey(p => p.PatientId);
        }
    }
}