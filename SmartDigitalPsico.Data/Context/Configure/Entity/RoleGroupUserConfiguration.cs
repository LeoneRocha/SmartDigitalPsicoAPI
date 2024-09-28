using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Entity
{
    public class RoleGroupUserConfiguration : EntityBaseConfiguration<RoleGroupUser>
    {
        public RoleGroupUserConfiguration(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
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
        }
    }
}
