using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Data.Context.Configure.Helper;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class MedicalSettingsConfiguration : EntityBaseConfiguration<MedicalSettings>
    {
        public MedicalSettingsConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }

        public override void Configure(EntityTypeBuilder<MedicalSettings> builder)
        {
            builder.ToTable("MedicalSettings", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);

            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.GoogleCalendarId).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(e => e.GoogleAccessToken).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(e => e.GoogleRefreshToken).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(e => e.GoogleTokenExpiry).HasColumnType("datetime");

            // Relationship
            builder.HasOne(e => e.Medical)
                   .WithMany()
                   .HasForeignKey(e => e.MedicalId)
                   .OnDelete(DeleteBehavior.Cascade);  // Cascade delete when Medical is deleted
        }
    }
}