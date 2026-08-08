using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Data.Context.Configure.Helper;
using SmartDigitalPsico.Data.Context.Configure.Mock;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    /// <summary>
    /// Classe responsável por GenderConfiguration.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class GenderConfiguration : EntityBaseConfiguration<Gender>
    {
        /// <summary>
        /// Método GenderConfiguration: executa a operação GenderConfiguration.
        /// </summary>
        public GenderConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public override void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.ToTable("Gender", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Description).HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(e => e.Language).HasMaxLength(10).HasColumnType("varchar(10)");

            builder.HasData(GenderMockData.GetMock()); 
        }
    }
}
