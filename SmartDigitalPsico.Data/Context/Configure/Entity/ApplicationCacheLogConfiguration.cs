using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper;
using SmartDigitalPsico.Core.SDK.Data.Context.Configure;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    /// <summary>
    /// Classe responsável por ApplicationCacheLogConfiguration.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class ApplicationCacheLogConfiguration : SmartDigitalPsico.Core.SDK.Data.Context.Configure.EntityBaseConfiguration<ApplicationCacheLog>
    {
        /// <summary>
        /// Método ApplicationCacheLogConfiguration: executa a operação ApplicationCacheLogConfiguration.
        /// </summary>
        public ApplicationCacheLogConfiguration(ETypeDataBase eTypeDataBase) :base(eTypeDataBase) { }
         
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public override void Configure(EntityTypeBuilder<ApplicationCacheLog> builder)
        {
            builder.ToTable("ApplicationCacheLog", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Enable);
            builder.Property(c => c.DateTimeSlidingExpiration);
            builder.Property(c => c.CacheId).HasMaxLength(255);
            builder.Property(c => c.CacheKey).HasMaxLength(255);
        }
    }
}
