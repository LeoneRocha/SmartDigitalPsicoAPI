using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.User;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IUserService : IEntityBaseService<User, AddUserDto, UpdateUserDto, GetUserDto>
    {
        Task<ServiceResponse<GetUserAuthenticatedDto>> Login(string login, string password);
        Task<ServiceResponse<bool>> Logout(string login);

        Task<ServiceResponse<GetUserDto>> Register(UserRegisterDto userRegisterVO);

        Task<ServiceResponse<GetUserDto>> UpdateProfile(UpdateUserProfileDto userUpdateProfileVO);
    }
}