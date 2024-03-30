using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.ConfigureFluentAPI.Entity
{
    public class MedicalCalendarConfiguration : IEntityTypeConfiguration<MedicalCalendar>
    {
        public void Configure(EntityTypeBuilder<MedicalCalendar> builder)
        {
            builder.ToTable("MedicalCalendar", "dbo");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Title).HasMaxLength(100).HasColumnType("varchar(100)");
            builder.Property(e => e.StartDate);
            builder.Property(e => e.EndDate);
            builder.Property(e => e.AllDay);
            builder.Property(e => e.Status).HasConversion<byte>();

            builder.Property(e => e.ColorCategory)
                .HasMaxLength(50)
                .HasColumnType("varchar(50)");

            builder.Property(e => e.Url)
                .HasMaxLength(150)
                .HasColumnType("varchar(150)");

            builder.Property(e => e.PushedCalendar);

            builder.Property(e => e.TimeZone)
                .HasMaxLength(150)
                .HasColumnType("varchar(150)");

            // Relationship
            builder.HasOne(e => e.Medical)
                .WithMany()
                .HasForeignKey(e => e.MedicalId);

            builder.HasOne(e => e.Patient)
                .WithMany()
                .HasForeignKey(e => e.PatientId);

            builder.HasOne(e => e.CreatedUser)
                .WithMany()
                .HasForeignKey(e => e.CreatedUserId);

            builder.HasOne(e => e.ModifyUser)
                .WithMany()
                .HasForeignKey(e => e.ModifyUserId);
        }
    }


}
