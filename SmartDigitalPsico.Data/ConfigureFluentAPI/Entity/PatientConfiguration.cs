using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.ConfigureFluentAPI.Entity
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("Patients", "dbo");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Name).HasMaxLength(255).IsRequired().HasColumnType("varchar(255)");
            builder.Property(e => e.Email).HasMaxLength(100).IsRequired().HasColumnType("varchar(100)");
            builder.Property(e => e.DateOfBirth);
            builder.Property(e => e.Profession).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(e => e.Cpf).HasMaxLength(15).HasColumnType("varchar(15)");
            builder.Property(e => e.Rg).HasMaxLength(15).IsRequired().HasColumnType("varchar(15)");
            builder.Property(e => e.Education).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(e => e.MaritalStatus).HasConversion<byte>();
            builder.Property(e => e.PhoneNumber).HasMaxLength(20).HasColumnType("varchar(20)");
            builder.Property(e => e.AddressStreet).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(e => e.AddressNeighborhood).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(e => e.AddressCity).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(e => e.AddressState).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(e => e.AddressCep).HasMaxLength(20).HasColumnType("varchar(20)");
            builder.Property(e => e.EmergencyContactName).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(e => e.EmergencyContactPhoneNumber).HasMaxLength(20).HasColumnType("varchar(20)");

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

            builder.HasMany(e => e.PatientAdditionalInformations)
                .WithOne();

            builder.HasMany(e => e.PatientHospitalizationInformations)
                .WithOne();

            builder.HasMany(e => e.PatientMedicationInformations)
                .WithOne();

            builder.HasMany(e => e.PatientRecords)
                .WithOne();
        }
    }
}