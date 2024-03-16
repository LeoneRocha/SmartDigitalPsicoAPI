using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IUserRepository : IEntityBaseRepository<User>
    {
        Task<User> FindByEmail(string value);
        Task<User> FindByLogin(string login);
        Task<User> RefreshUserInfo(User user);
        Task<User> Register(User entityAdd);
        Task<bool> UserExists(string login);
    }
}
