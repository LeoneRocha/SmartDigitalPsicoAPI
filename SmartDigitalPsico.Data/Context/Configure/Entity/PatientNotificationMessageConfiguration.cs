using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper;
using SmartDigitalPsico.Data.Context.Configure.Mock;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    /// <summary>
    /// Classe responsável por PatientNotificationMessageConfiguration.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class PatientNotificationMessageConfiguration : SmartDigitalPsico.Core.SDK.Data.Context.Configure.EntityBaseConfiguration<PatientNotificationMessage>
    {
        /// <summary>
        /// Método PatientNotificationMessageConfiguration: executa a operação PatientNotificationMessageConfiguration.
        /// </summary>
        public PatientNotificationMessageConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
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

            builder.HasData(PatientNotificationMessageMockData.GetMock());
        }
    }
}
