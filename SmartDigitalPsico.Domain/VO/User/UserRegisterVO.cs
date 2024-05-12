namespace SmartDigitalPsico.Domain.VO.User
{
    public class UserRegisterVO : AddUserVO
    {
        public UserRegisterVO()
        {
            RoleGroupsIds = Array.Empty<long>();
        }
    }
}