using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.ConfigureFluentAPI.Entity
{
    public class RoleGroupConfiguration : IEntityTypeConfiguration<RoleGroup>
    {
        public void Configure(EntityTypeBuilder<RoleGroup> builder)
        {
            builder.ToTable("RoleGroups", "dbo");
            builder.HasKey(e => e.Id);
            // Properties
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Enable);
            builder.Property(e => e.Description).HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(e => e.Language).HasMaxLength(10).HasColumnType("varchar(10)");
            builder.Property(e => e.RolePolicyClaimCode).HasMaxLength(25).HasColumnType("varchar(25)");

            // Relationship
            builder.HasMany(m => m.Users).WithMany(s => s.RoleGroups).UsingEntity(j => j.ToTable("RoleGroupUser"));//RolesGroupUser 
        }
    }
}
