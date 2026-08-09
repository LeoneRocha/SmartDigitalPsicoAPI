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
    /// Classe responsável por SpecialtyConfiguration.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class SpecialtyConfiguration : SmartDigitalPsico.Core.SDK.Data.Context.Configure.EntityBaseConfiguration<Specialty>
    {
        /// <summary>
        /// Método SpecialtyConfiguration: executa a operação SpecialtyConfiguration.
        /// </summary>
        public SpecialtyConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public override void Configure(EntityTypeBuilder<Specialty> builder)
        {
            builder.ToTable("Specialty", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Description).HasMaxLength(255).HasColumnType(EntityTypeConfigurationConstants.Type_Varchar_255);
            builder.Property(e => e.Language).HasMaxLength(10).HasColumnType("varchar(10)");

            builder.HasData(SpecialtyMockData.GetMock());
        }
    }
}
