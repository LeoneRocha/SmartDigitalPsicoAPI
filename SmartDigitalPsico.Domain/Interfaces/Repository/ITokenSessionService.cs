using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface ITokenSessionService
    {
        Task<UserTokenSession?> GetSessionAsync(long userId);

        Task SaveSessionAsync(UserTokenSession session);
    }
}
