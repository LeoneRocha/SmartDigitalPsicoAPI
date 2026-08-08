using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper;
using SmartDigitalPsico.Data.Context.Configure.Mock;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    /// <summary>
    /// Classe responsável por PatientAdditionalInformationConfiguration.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class PatientAdditionalInformationConfiguration : SmartDigitalPsico.Core.SDK.Data.Context.Configure.EntityBaseConfiguration<PatientAdditionalInformation>
    {
        /// <summary>
        /// Método PatientAdditionalInformationConfiguration: executa a operação PatientAdditionalInformationConfiguration.
        /// </summary>
        public PatientAdditionalInformationConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public override void Configure(EntityTypeBuilder<PatientAdditionalInformation> builder)
        {  
            builder.ToTable("PatientAdditionalInformation", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.FollowUp_Psychiatric).HasMaxLength(2000).HasColumnType("varchar(2000)");
            builder.Property(e => e.FollowUp_Neurological).HasMaxLength(2000).HasColumnType("varchar(2000)");
            // Relationship
            builder.HasOne(e => e.Patient).WithMany().HasForeignKey(e => e.PatientId);
            builder.HasOne(e => e.CreatedUser).WithMany().HasForeignKey(e => e.CreatedUserId);
            builder.HasOne(e => e.ModifyUser).WithMany().HasForeignKey(e => e.ModifyUserId);

            builder.HasOne(e => e.Patient).WithMany(p => p.PatientAdditionalInformations).HasForeignKey(e => e.PatientId);

            builder.HasData(PatientAdditionalInformationMockData.GetMock());
        }
    }
}
