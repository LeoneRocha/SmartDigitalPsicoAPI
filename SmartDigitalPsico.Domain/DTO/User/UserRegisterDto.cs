namespace SmartDigitalPsico.Domain.DTO.User
{
    public class UserRegisterDto : AddUserDto
    {
        public UserRegisterDto()
        {
            RoleGroupsIds = Array.Empty<long>();
        }
    }
}