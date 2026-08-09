using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

using SmartDigitalPsico.Domain.EntityModels;
using SmartDigitalPsico.Data.Context.Mock;

namespace SmartDigitalPsico.Data.Context.Configure
{
    /// <summary>
    /// Classe responsável por RoleGroupUserConfiguration.
    /// Responsabilidade: configuração de startup/DI da aplicação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class RoleGroupUserConfiguration : SmartDigitalPsico.Core.SDK.Data.Context.Configure.EntityBaseConfiguration<RoleGroupUser>
    {
        /// <summary>
        /// Método RoleGroupUserConfiguration: executa a operação RoleGroupUserConfiguration.
        /// </summary>
        public RoleGroupUserConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        /// <summary>
        /// Método Configure: configura estado ou dependencias.
        /// </summary>
        public override void Configure(EntityTypeBuilder<RoleGroupUser> builder)
        {
            builder.ToTable("RoleGroupUser", "dbo");
            HelperCharSet.AddCharSet(builder, ETypeDataBase);
            builder.HasKey(e => new { e.UserId, e.RoleGroupId });
            // Properties
            builder.Property(e => e.UserId);
            builder.Property(e => e.RoleGroupId);

            // Relationship
            builder.HasOne(e => e.User).WithMany(p => p.UserRoleGroups).HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.RoleGroup).WithMany(p => p.UserRoleGroups).HasForeignKey(e => e.RoleGroupId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(RoleGroupUserMockData.GetMock());
        }
    }
}
