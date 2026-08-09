using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper;
using SmartDigitalPsico.Core.SDK.Domain.Constants;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Data.Context.Configure
{
    /// <summary>
    /// Classe responsável por UserTokenSessionConfiguration.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class UserTokenSessionConfiguration : SmartDigitalPsico.Core.SDK.Data.Context.Configure.EntityBaseConfiguration<UserTokenSession>
    {
        /// <summary>
        /// Método UserTokenSessionConfiguration: executa a operação UserTokenSessionConfiguration.
        /// </summary>
        public UserTokenSessionConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public override void Configure(EntityTypeBuilder<UserTokenSession> builder)
        {
            builder.ToTable("UserTokenSession", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);

            builder.Property(e => e.AccessToken)
                 .HasMaxLength(4000)
                 .HasColumnType(EntityTypeConfigurationConstants.GetTypeTextByTypeDataBase(ETypeDataBase))
                 .IsRequired();

            builder.Property(e => e.RefreshToken)
             .HasMaxLength(4000)
             .HasColumnType(EntityTypeConfigurationConstants.GetTypeTextByTypeDataBase(ETypeDataBase))
             .IsRequired();

            builder.Property(e => e.RefreshTokenExpiryTime)
                .HasColumnName("Refresh_token_expiry_time")
                .IsRequired();

            builder.Property(e => e.LastAccessDate).IsRequired();
            builder.Property(e => e.CreatedDate).IsRequired();
            builder.Property(e => e.ModifyDate).IsRequired();

            builder.Property(e => e.ExpiresAt).IsRequired();

            // Relationship 
            builder.HasOne(ts => ts.User)
                  .WithOne(u => u.TokenSession)
                  .HasForeignKey<UserTokenSession>(ts => ts.UserId);
        }
    }
}
