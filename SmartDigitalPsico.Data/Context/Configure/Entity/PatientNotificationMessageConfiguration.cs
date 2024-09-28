using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class PatientNotificationMessageConfiguration : EntityBaseConfiguration<PatientNotificationMessage>
    {
        public PatientNotificationMessageConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        public override void Configure(EntityTypeBuilder<PatientNotificationMessage> builder)
        {
            builder.ToTable("PatientNotificationMessage", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.MessagePatient).HasMaxLength(2000).IsRequired().HasColumnType("varchar(2000)");
            builder.Property(e => e.IsReaded);
            builder.Property(e => e.ReadingDate);
            builder.Property(e => e.Notified);
            builder.Property(e => e.NotifiedDate);

            // Relationship
            builder.HasOne(e => e.CreatedUser).WithMany().HasForeignKey(e => e.CreatedUserId);
            builder.HasOne(e => e.ModifyUser).WithMany().HasForeignKey(e => e.ModifyUserId);
            builder.HasOne(e => e.Patient).WithMany().HasForeignKey(e => e.PatientId);
        }
    }
}
