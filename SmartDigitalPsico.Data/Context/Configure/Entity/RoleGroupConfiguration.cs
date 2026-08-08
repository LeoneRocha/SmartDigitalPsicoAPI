using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper;
using SmartDigitalPsico.Core.SDK.Data.Context.Configure;
using SmartDigitalPsico.Data.Context.Configure.Mock;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    /// <summary>
    /// Classe responsável por RoleGroupConfiguration.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class RoleGroupConfiguration : SmartDigitalPsico.Core.SDK.Data.Context.Configure.EntityBaseConfiguration<RoleGroup>
    {
        /// <summary>
        /// Método RoleGroupConfiguration: executa a operação RoleGroupConfiguration.
        /// </summary>
        public RoleGroupConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public override void Configure(EntityTypeBuilder<RoleGroup> builder)
        {
            builder.ToTable("RoleGroup", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Description).HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(e => e.Language).HasMaxLength(10).HasColumnType("varchar(10)");
            builder.Property(e => e.RolePolicyClaimCode).HasMaxLength(25).HasColumnType("varchar(25)");

            builder.HasData(RoleGroupMockData.GetMock());
        }
    }
}
