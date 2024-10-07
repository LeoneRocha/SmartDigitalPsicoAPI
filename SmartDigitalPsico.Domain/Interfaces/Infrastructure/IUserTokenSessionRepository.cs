using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface ITokenSessionPersistenceAdapter
    {
        Task<UserTokenSession?> GetSessionAsync(long userId);
        Task SaveSessionAsync(UserTokenSession userTokenSession);
    }
} 