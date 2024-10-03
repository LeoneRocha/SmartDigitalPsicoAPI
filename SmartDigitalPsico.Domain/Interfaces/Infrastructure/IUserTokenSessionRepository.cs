using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface ITokenSessionAdapter
    {
        Task<UserTokenSession> GetSessionAsync(long userId);
        Task SaveSessionAsync(UserTokenSession userTokenSession);
    }
} 