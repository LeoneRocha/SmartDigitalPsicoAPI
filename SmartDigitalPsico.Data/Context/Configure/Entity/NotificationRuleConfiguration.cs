using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper;
using SmartDigitalPsico.Data.Context.Configure.Mock;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.EntityModels.Schedule;
using EIntervalNotificationType = SmartDigitalPsico.Core.SDK.Domain.Enuns.EIntervalNotificationType;
using ENotificationServiceType = SmartDigitalPsico.Core.SDK.Domain.Enuns.ENotificationServiceType;
using ENotificationType = SmartDigitalPsico.Domain.Enuns.ENotificationType;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    /// <summary>
    /// Classe responsável por NotificationRuleConfiguration.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class NotificationRuleConfiguration : SmartDigitalPsico.Core.SDK.Data.Context.Configure.EntityBaseConfiguration<NotificationRule>
    {
        /// <summary>
        /// Método NotificationRuleConfiguration: executa a operação NotificationRuleConfiguration.
        /// </summary>
        public NotificationRuleConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }

        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public override void Configure(EntityTypeBuilder<NotificationRule> builder)
        {
            builder.ToTable("NotificationRules", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);

            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.MedicalId).IsRequired();
            builder.Property(e => e.IsEnabled).IsRequired();
            builder.Property(e => e.IntervalType).IsRequired()
               .HasConversion(
                   v => (short)v,
                   v => (EIntervalNotificationType)v);
            builder.Property(e => e.IntervalValue).IsRequired();
            builder.Property(e => e.IsBefore).IsRequired();
            builder.Property(e => e.ENotificationServiceType)
                .HasMaxLength(100)
                .HasConversion(
                    v => string.Join(',', v.Select(d => ((int)d).ToString())),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(s => (ENotificationServiceType)int.Parse(s)).ToArray(),
                    CollectionValueComparerHelper.ForArray<ENotificationServiceType>())
                .IsRequired();
            builder.Property(e => e.Description).HasMaxLength(255).IsRequired();
            builder.Property(e => e.CreatedDate).IsRequired(true);
            builder.Property(e => e.ModifyDate).IsRequired(true);

            builder.Property(e => e.NotificationType).IsRequired()
                .HasConversion(
                    v => (short)v,
                    v => (ENotificationType)v);

            // Relationship  
            builder.HasOne(e => e.Medical).WithMany().HasForeignKey(e => e.MedicalId);
             
            // Indexes (using Fluent API)
            builder.HasIndex(e => e.MedicalId).HasDatabaseName("IX_NotificationRules_MedicalId");

            builder.HasData(NotificationRulesMockData.GetMock());
        }
    } 
} 
