using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    public class RoleGroupUserMockData : EntityBaseConfiguration<RoleGroupUser>
    {
        public RoleGroupUserMockData(ETypeDataBase eTypeDataBase) : base(eTypeDataBase) { }
        public override void Configure(EntityTypeBuilder<RoleGroupUser> modelBuilder)
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

        public static RoleGroupUser[] GetMockUnitTest()
        {
            var userAdmin = new RoleGroupUser
            {
                RoleGroupId = 1,
                UserId = 1,
            };

            var userMedical = new RoleGroupUser
            {
                RoleGroupId = 2,
                UserId = 2,
            };

            return [
                userAdmin ,userMedical
            ];
        }
    }
}