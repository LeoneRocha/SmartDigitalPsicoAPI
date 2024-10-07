using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Service.Infrastructure.Authentication
{
    public class DatabaseTokenSessionAdapter : ITokenSessionPersistenceAdapter
    {
        private readonly IUserTokenSessionRepository _userTokenSessionRepository;

        public DatabaseTokenSessionAdapter(IUserTokenSessionRepository  userTokenSessionRepository)
        {
             _userTokenSessionRepository = userTokenSessionRepository;
        }

        public async Task<UserTokenSession?> GetSessionAsync(long userId)
        {
            return await _userTokenSessionRepository.GetSessionAsync(userId);
        }

        public async Task SaveSessionAsync(UserTokenSession session)
        { 
            await _userTokenSessionRepository.SaveSessionAsync(session);
        }
    }
}