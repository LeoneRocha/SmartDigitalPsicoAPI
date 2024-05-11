using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.User;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IUserService : IEntityBaseService<User, AddUserVO, UpdateUserVO, GetUserVO>
    {
        Task<ServiceResponse<GetUserAuthenticatedVO>> Login(string login, string password);
        Task<ServiceResponse<bool>> Logout(string login);

        Task<ServiceResponse<GetUserVO>> Register(UserRegisterVO userRegisterVO);

        Task<ServiceResponse<GetUserVO>> UpdateProfile(UpdateUserProfileVO userUpdateProfileVO);
    }
}