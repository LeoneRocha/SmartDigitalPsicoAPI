using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.ConfigureFluentAPI.Mock
{
    public class RoleGroupUserMockData : IEntityTypeConfiguration<RoleGroupUser>
    {
        public void Configure(EntityTypeBuilder<RoleGroupUser> modelBuilder)
        {
            modelBuilder.HasData(GetMock()); 
        }
        public static RoleGroupUser[] GetMock()
        {
            var userAdmin = new RoleGroupUser
            { 
                RoleGroupId = 1,
                UserId = 1,
            }; 

            return [
                userAdmin 
            ];
        }
    }
}