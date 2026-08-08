using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Data.Context.Configure.Helper;
using SmartDigitalPsico.Data.Context.Configure.Mock;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    /// <summary>
    /// Classe responsável por PatientRecordConfiguration.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class PatientRecordConfiguration : EntityBaseConfiguration<PatientRecord>
    {
        /// <summary>
        /// Método PatientRecordConfiguration: executa a operação PatientRecordConfiguration.
        /// </summary>
        public PatientRecordConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public override void Configure(EntityTypeBuilder<PatientRecord> builder)
        {
            builder.ToTable("PatientRecord", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Description)
                .HasMaxLength(255)
                .IsRequired()
                .HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.Annotation)
                .HasMaxLength(4000)
                .HasColumnType(EntityTypeConfigurationConstants.GetTypeTextByTypeDataBase(ETypeDataBase))
                .IsRequired();
            builder.Property(e => e.AnnotationDate);

            // Relationship
            builder.HasOne(e => e.CreatedUser).WithMany().HasForeignKey(e => e.CreatedUserId);
            builder.HasOne(e => e.ModifyUser).WithMany().HasForeignKey(e => e.ModifyUserId);

            builder.HasOne(e => e.Patient).WithMany(p => p.PatientRecords).HasForeignKey(e => e.PatientId);

            builder.Property(e => e.TableStorageRowKey)
                .HasMaxLength(40)
                .IsRequired(false);

            builder.HasData(PatientRecordMockData.GetMock());
        }
    }

}
