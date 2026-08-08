using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper;
using SmartDigitalPsico.Data.Context.Configure.Mock;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    /// <summary>
    /// Classe responsável por ApplicationConfigSettingConfiguration.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class ApplicationConfigSettingConfiguration : SmartDigitalPsico.Core.SDK.Data.Context.Configure.EntityBaseConfiguration<ApplicationConfigSetting>
    {
        /// <summary>
        /// Método ApplicationConfigSettingConfiguration: executa a operação ApplicationConfigSettingConfiguration.
        /// </summary>
        public ApplicationConfigSettingConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public override void Configure(EntityTypeBuilder<ApplicationConfigSetting> builder)
        {
            builder.ToTable("ApplicationConfigSetting", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Enable);
            builder.Property(c => c.Description).HasMaxLength(255);
            builder.Property(c => c.UrlRootManager).HasMaxLength(255);
            builder.Property(c => c.Language).HasMaxLength(10);
            builder.Property(c => c.EndPointUrl_StorageFiles).HasMaxLength(255);
            builder.Property(c => c.EndPointUrl_Cache).HasMaxLength(255);
            builder.Property(c => c.TypeLocationSaveFiles).HasConversion<byte>();
            builder.Property(c => c.TypeLocationCache).HasConversion<byte>();
            builder.Property(c => c.TypeLocationQueeMessaging).HasConversion<byte>();
             
            builder.HasData(ApplicationConfigSettingMockData.GetMock());
        }
    }
}
