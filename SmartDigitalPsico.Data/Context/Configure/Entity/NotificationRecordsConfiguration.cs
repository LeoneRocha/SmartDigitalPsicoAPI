using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using SmartDigitalPsico.Data.Context.Configure.Helper;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class NotificationRecordsConfiguration : EntityBaseConfiguration<NotificationRecords>
    {
        public NotificationRecordsConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }

        public override void Configure(EntityTypeBuilder<NotificationRecords> builder)
        {
            builder.ToTable("NotificationRecords", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);

            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.MedicalCalendarId).IsRequired(false);
            builder.Property(e => e.NotificationRules)
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<NotificationRuleStatus[]>(v)!)
                .HasMaxLength(EntityTypeConfigurationConstants.GetMaxLengthByTypeDataBase(ETypeDataBase))
                .HasColumnType(EntityTypeConfigurationConstants.GetTypeTextByTypeDataBase(ETypeDataBase))
                .IsRequired();
             
            builder.Property(e => e.CreatedDate).IsRequired();
            builder.Property(e => e.ModifyDate).IsRequired();

            // Propriedade usada para filtragem rápida de notificações pendentes.
            builder.Property(e => e.NextScheduledSendTime)
                   .IsRequired(false);

            // Novo controle para indicar conclusão dos envios:
            builder.Property(e => e.IsCompleted)
                   .IsRequired();
            builder.Property(e => e.FinalSendDate)
                   .IsRequired(false);

            // Relationship  
            builder.HasOne(e => e.MedicalCalendar).WithMany().HasForeignKey(e => e.MedicalCalendarId);

            // Indexes (using Fluent API) 
            // Índices para melhorar a performance das consultas. 
            builder.HasIndex(e => e.MedicalCalendarId).HasDatabaseName("IX_NotificationRecords_MedicalCalendarId");            
            builder.HasIndex(e => e.NextScheduledSendTime).HasDatabaseName("IX_NotificationRecords_NextScheduledSendTime");
            builder.HasIndex(e => e.IsCompleted).HasDatabaseName("IX_NotificationRecords_IsCompleted");
        }
    }
}