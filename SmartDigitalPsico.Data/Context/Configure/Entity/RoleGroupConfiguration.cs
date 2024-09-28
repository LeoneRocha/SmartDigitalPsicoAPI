using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class RoleGroupConfiguration : EntityBaseConfiguration<RoleGroup>
    {
        public override void Configure(EntityTypeBuilder<RoleGroup> builder)
        {
            builder.ToTable("RoleGroup", "dbo");
            HelperCharSet.AddCharSet(builder);
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Description).HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(e => e.Language).HasMaxLength(10).HasColumnType("varchar(10)");
            builder.Property(e => e.RolePolicyClaimCode).HasMaxLength(25).HasColumnType("varchar(25)");
        }
    }
}
