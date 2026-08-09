using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Data.Context.Mock;

namespace SmartDigitalPsico.Data.Context.Configure
{
    /// <summary>
    /// Classe responsável por PatientInfoTagConfiguration.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class PatientInfoTagConfiguration : SmartDigitalPsico.Core.SDK.Data.Context.Configure.EntityBaseConfiguration<PatientInfoTag>
    {
        /// <summary>
        /// Método PatientInfoTagConfiguration: executa a operação PatientInfoTagConfiguration.
        /// </summary>
        public PatientInfoTagConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public override void Configure(EntityTypeBuilder<PatientInfoTag> builder)
        {
            builder.ToTable("PatientInfoTag", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => new { e.InfoTagId, e.PatientId });
            // Properties
            builder.Property(e => e.InfoTagId);
            builder.Property(e => e.PatientId);

            // Relationship
            builder.HasOne(e => e.InfoTag).WithMany(p => p.PatientInfoTags).HasForeignKey(e => e.InfoTagId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.Patient).WithMany(p => p.PatientInfoTags).HasForeignKey(e => e.PatientId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(PatientInfoTagMockData.GetMock());
        }
    }
}
