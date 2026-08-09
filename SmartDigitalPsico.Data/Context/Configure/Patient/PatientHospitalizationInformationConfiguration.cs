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
    /// Classe responsável por PatientHospitalizationInformationConfiguration.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class PatientHospitalizationInformationConfiguration : SmartDigitalPsico.Core.SDK.Data.Context.Configure.EntityBaseConfiguration<PatientHospitalizationInformation>
    {
        /// <summary>
        /// Método PatientHospitalizationInformationConfiguration: executa a operação PatientHospitalizationInformationConfiguration.
        /// </summary>
        public PatientHospitalizationInformationConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public override void Configure(EntityTypeBuilder<PatientHospitalizationInformation> builder)
        {
            builder.ToTable("PatientHospitalizationInformation", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Description).HasMaxLength(255).IsRequired().HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.StartDate);
            builder.Property(e => e.EndDate);
            builder.Property(e => e.CID).HasMaxLength(20).IsRequired().HasColumnType("varchar(20)");
            builder.Property(e => e.Observation).HasMaxLength(2000).IsRequired().HasColumnType("varchar(2000)");
            // Relationship            
            builder.HasOne(e => e.CreatedUser).WithMany().HasForeignKey(e => e.CreatedUserId);
            builder.HasOne(e => e.ModifyUser).WithMany().HasForeignKey(e => e.ModifyUserId);
            builder.HasOne(e => e.Patient).WithMany(p => p.PatientHospitalizationInformations).HasForeignKey(e => e.PatientId);

            builder.HasData(PatientHospitalizationInformationMockData.GetMock());
        }
    }
}
