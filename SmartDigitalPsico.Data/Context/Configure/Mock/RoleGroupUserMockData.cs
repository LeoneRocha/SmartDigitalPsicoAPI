using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Configure.Mock
{
    public static class RoleGroupUserMockData  
    { 
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