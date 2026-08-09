using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper;
using SmartDigitalPsico.Core.SDK.Domain.Constants;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.EntityModels.Schedule;

namespace SmartDigitalPsico.Data.Context.Configure
{
    /// <summary>
    /// Classe responsável por ScheduleCalendarConfiguration.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class ScheduleCalendarConfiguration : SmartDigitalPsico.Core.SDK.Data.Context.Configure.EntityBaseConfiguration<ScheduleCalendar>
    {
        /// <summary>
        /// Método ScheduleCalendarConfiguration: operação de agendamento.
        /// </summary>
        public ScheduleCalendarConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }

        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public override void Configure(EntityTypeBuilder<ScheduleCalendar> builder)
        {
            builder.ToTable("ScheduleCalendar", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);

            builder.Property(e => e.TenantKey)
                .IsRequired()
                .HasMaxLength(64)
                .HasColumnType("varchar(64)");

            builder.Property(e => e.OwnerKey)
                .IsRequired()
                .HasMaxLength(128)
                .HasColumnType("varchar(128)");

            builder.Property(e => e.SubjectKey)
                .HasMaxLength(128)
                .HasColumnType("varchar(128)");

            builder.Property(e => e.UniqueToken)
                .IsRequired()
                .HasMaxLength(40)
                .HasColumnType("varchar(40)");

            builder.Property(e => e.StartPeriod);
            builder.Property(e => e.EndPeriod);

            builder.Property(e => e.ScheduleData)
                .IsRequired()
                .HasMaxLength(EntityTypeConfigurationConstants.GetMaxLengthByTypeDataBase(ETypeDataBase.Mysql))
                .HasColumnType(EntityTypeConfigurationConstants.GetTypeTextByTypeDataBase(ETypeDataBase.Mysql))
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<ScheduleCalendarItem[]>(v)!,
                    CollectionValueComparerHelper.ForJsonArray<ScheduleCalendarItem>());

            builder.HasIndex(p => p.UniqueToken)
                .HasDatabaseName("UX_ScheduleCalendar_UniqueToken")
                .IsUnique(true);

            builder.HasIndex(p => new { p.TenantKey, p.OwnerKey, p.StartPeriod, p.EndPeriod })
                .HasDatabaseName("IX_ScheduleCalendar_Tenant_Owner_Period")
                .IsUnique(false);
        }
    }
}
