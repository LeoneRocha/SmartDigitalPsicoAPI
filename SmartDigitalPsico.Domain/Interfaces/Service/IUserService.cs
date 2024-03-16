using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.User;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IUserService : IEntityBaseService<User, AddUserVO, UpdateUserVO, GetUserVO>
    {
        Task<ServiceResponse<GetUserAuthenticatedVO>> Login(string username, string password);
        Task<ServiceResponse<bool>> Logout(string username);

        Task<ServiceResponse<GetUserVO>> Register(UserRegisterVO newEntity);

        Task<ServiceResponse<GetUserVO>> UpdateProfile(UpdateUserProfileVO updateEntity);
    }
}