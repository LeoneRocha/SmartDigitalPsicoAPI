using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Data.Context.Configure.Helper;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    /// <summary>
    /// Classe responsável por MedicalSettingsConfiguration.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class MedicalSettingsConfiguration : EntityBaseConfiguration<MedicalSettings>
    {
        /// <summary>
        /// Método MedicalSettingsConfiguration: executa a operação MedicalSettingsConfiguration.
        /// </summary>
        public MedicalSettingsConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }

        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public override void Configure(EntityTypeBuilder<MedicalSettings> builder)
        {
            builder.ToTable("MedicalSettings", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);

            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.GoogleCalendarId).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(e => e.GoogleAccessToken).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(e => e.GoogleRefreshToken).HasMaxLength(255).HasColumnType("varchar(255)");
            builder.Property(e => e.GoogleTokenExpiry).HasColumnType("datetime");

            // Relationship (WithMany na coleção evita FK sombra MedicalId1)
            builder.HasOne(e => e.Medical)
                   .WithMany(m => m.MedicalSettings)
                   .HasForeignKey(e => e.MedicalId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
