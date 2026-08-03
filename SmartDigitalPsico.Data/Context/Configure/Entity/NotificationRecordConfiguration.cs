using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using SmartDigitalPsico.Data.Context.Configure.Helper;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    /// <summary>
    /// Classe responsável por NotificationRecordConfiguration.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class NotificationRecordConfiguration : EntityBaseConfiguration<NotificationRecord>
    {
        /// <summary>
        /// Método NotificationRecordConfiguration: executa a operação NotificationRecordConfiguration.
        /// </summary>
        public NotificationRecordConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }

        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public override void Configure(EntityTypeBuilder<NotificationRecord> builder)
        {
            builder.ToTable("NotificationRecords", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.TokenId).IsRequired();
            builder.Property(e => e.EventDate).IsRequired();
            builder.Property(e => e.NotificationRules)
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<NotificationRuleStatus[]>(v)!,
                    CollectionValueComparerHelper.ForJsonArray<NotificationRuleStatus>())
                .HasMaxLength(EntityTypeConfigurationConstants.GetMaxLengthByTypeDataBase(ETypeDataBase))
                .HasColumnType(EntityTypeConfigurationConstants.GetTypeTextByTypeDataBase(ETypeDataBase))
                .IsRequired();
             
            builder.Property(e => e.CreatedDate).IsRequired();
            builder.Property(e => e.ModifyDate).IsRequired();

            builder.Property(e => e.NextScheduledSendTime)
                   .IsRequired(false);

            builder.Property(e => e.IsCompleted)
                   .IsRequired();
            builder.Property(e => e.FinalSendDate)
                   .IsRequired(false);

            // Logical key for schedule reminders — no FK to ScheduleCalendar.
            builder.HasIndex(e => new { e.TokenId, e.EventDate })
                .HasDatabaseName("IX_NotificationRecords_TokenId_EventDate");
            builder.HasIndex(e => e.TokenId).HasDatabaseName("IX_NotificationRecords_TokenId");
            builder.HasIndex(e => e.NextScheduledSendTime).HasDatabaseName("IX_NotificationRecords_NextScheduledSendTime");
            builder.HasIndex(e => e.IsCompleted).HasDatabaseName("IX_NotificationRecords_IsCompleted");
        }
    }
}
