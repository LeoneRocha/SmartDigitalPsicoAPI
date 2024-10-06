using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface ITokenSessionPersistenceService
    {
        Task<UserTokenSession?> GetSessionAsync(long userId);

        Task SaveSessionAsync(UserTokenSession session);
    }
}
