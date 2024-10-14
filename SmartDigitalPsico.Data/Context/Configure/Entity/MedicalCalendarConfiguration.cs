using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class MedicalCalendarConfiguration : EntityBaseConfiguration<MedicalCalendar>
    {
        public MedicalCalendarConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        public override void Configure(EntityTypeBuilder<MedicalCalendar> builder)
        {
            builder.ToTable("MedicalCalendar", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnType("varchar(100)");

            builder.Property(e => e.Description)
                .HasMaxLength(1000)
                .HasColumnType(EntityTypeConfigurationConstants.GetTypeTextByTypeDataBase(ETypeDataBase));

            builder.Property(e => e.StartDateTime);
            builder.Property(e => e.EndDateTime);
            builder.Property(e => e.IsAllDay);
            builder.Property(e => e.Status)
                .HasConversion<byte>();

            builder.Property(e => e.ColorCategoryHexa)
                .HasMaxLength(50)
                .HasColumnType("varchar(50)");

            builder.Property(e => e.Location)
                .HasMaxLength(255)
                .HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);

            builder.Property(e => e.IsPushedCalendar);

            builder.Property(e => e.TimeZone).HasMaxLength(150).HasColumnType("varchar(150)");

            //Array int 
            builder.Property(e => e.RecurrenceDays)
                .HasMaxLength(20)
                .HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_20)
                .HasConversion(v => string.Join(',', v.Select(d => ((int)d).ToString())), v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(s => (DayOfWeek)int.Parse(s)).ToArray());

            builder.Property(e => e.RecurrenceType);
            builder.Property(e => e.RecurrenceEndDate);
            builder.Property(e => e.RecurrenceCount);

            // Relationship
            builder.HasOne(e => e.CreatedUser).WithMany().HasForeignKey(e => e.CreatedUserId);
            builder.HasOne(e => e.ModifyUser).WithMany().HasForeignKey(e => e.ModifyUserId);

            builder.HasOne(e => e.Medical).WithMany().HasForeignKey(e => e.MedicalId);
            builder.HasOne(e => e.Patient).WithMany().HasForeignKey(e => e.PatientId);

            // Index
            builder.HasIndex(p => new { p.Title })
                .IncludeProperties(p => new { p.PatientId, p.MedicalId, p.StartDateTime, p.EndDateTime })
                .HasDatabaseName("Idx_Title_Inc_PatientId_MedicalId_StartDateTime_EndDateTime")
                .IsUnique(false);

            if (ETypeDataBase == ETypeDataBase.Mysql)
            {
                // Index FOR MYSQL 
                builder.HasIndex(p => new { p.Title, p.PatientId, p.MedicalId, p.StartDateTime, p.EndDateTime })
                    .HasDatabaseName("Idx_Title_PatientId_MedicalId_StartDateTime_EndDateTime")
                    .IsUnique(false);
            } 
        }
    }
}