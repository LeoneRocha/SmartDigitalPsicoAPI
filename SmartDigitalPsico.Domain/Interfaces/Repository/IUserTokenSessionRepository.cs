using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IUserTokenSessionRepository : IEntityBaseRepository<UserTokenSession>
    {
        Task<UserTokenSession?> GetSessionAsync(long userId);

        Task SaveSessionAsync(UserTokenSession session);
    }
} 