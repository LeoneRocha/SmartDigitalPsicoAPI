using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper;
using SmartDigitalPsico.Core.SDK.Domain.Constants;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Data.Context.Mock;

namespace SmartDigitalPsico.Data.Context.Configure
{
    /// <summary>
    /// Classe responsável por PatientMedicationInformationConfiguration.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class PatientMedicationInformationConfiguration : SmartDigitalPsico.Core.SDK.Data.Context.Configure.EntityBaseConfiguration<PatientMedicationInformation>
    {
        /// <summary>
        /// Método PatientMedicationInformationConfiguration: executa a operação PatientMedicationInformationConfiguration.
        /// </summary>
        public PatientMedicationInformationConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public override void Configure(EntityTypeBuilder<PatientMedicationInformation> builder)
        {
            builder.ToTable("PatientMedicationInformation", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Description).HasMaxLength(255).IsRequired().HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.StartDate);
            builder.Property(e => e.EndDate);
            builder.Property(e => e.Dosage).HasMaxLength(255).HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.Posology).HasMaxLength(255).HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.MainDrug).HasMaxLength(255).HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);

            // Relationship            
            builder.HasOne(e => e.CreatedUser).WithMany().HasForeignKey(e => e.CreatedUserId);
            builder.HasOne(e => e.ModifyUser).WithMany().HasForeignKey(e => e.ModifyUserId);
            builder.HasOne(e => e.Patient).WithMany(p => p.PatientMedicationInformations).HasForeignKey(e => e.PatientId);

            builder.HasData(PatientMedicationInformationMockData.GetMock());
        }
    }
}
