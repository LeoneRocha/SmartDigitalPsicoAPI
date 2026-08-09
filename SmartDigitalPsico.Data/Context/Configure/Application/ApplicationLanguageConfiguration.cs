using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Data.Context.Mock;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Context.Configure
{
    /// <summary>
    /// Classe responsável por ApplicationLanguageConfiguration.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class ApplicationLanguageConfiguration : SmartDigitalPsico.Core.SDK.Data.Context.Configure.EntityBaseConfiguration<ApplicationLanguage>
    {
        /// <summary>
        /// Método ApplicationLanguageConfiguration: executa a operação ApplicationLanguageConfiguration.
        /// </summary>
        public ApplicationLanguageConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public override void Configure(EntityTypeBuilder<ApplicationLanguage> builder)
        {
            builder.ToTable("ApplicationLanguage", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Enable);
            builder.Property(c => c.Language).HasMaxLength(6);
            builder.Property(c => c.Description).HasMaxLength(255);
            builder.Property(c => c.LanguageKey).HasMaxLength(100);
            builder.Property(c => c.ResourceKey).HasMaxLength(100);
            builder.Property(c => c.LanguageValue).HasMaxLength(255);
            // Index
            builder.HasIndex(p => new { p.ResourceKey, p.Language, p.LanguageKey })
            .HasDatabaseName("Idx_ApplicationLanguage_ResourceKey_Language_LanguageKey_Unique")
            .IsUnique();

            builder.HasData(ApplicationLanguageMockData.GetMock());
        }
    }
}
