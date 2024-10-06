using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Service.Infrastructure.Authentication
{
    public class TokenSessionService : ITokenSessionPersistenceService
    {
        private readonly ITokenSessionAdapter _tokenSessionAdapter;

        public TokenSessionService(ITokenSessionPersistenceFactory tokenSessionFactory)
        {
            _tokenSessionAdapter = tokenSessionFactory.Create("");
        }
        public async Task<UserTokenSession?> GetSessionAsync(long userId)
        {
            return await _tokenSessionAdapter.GetSessionAsync(userId);
        }

        public async Task SaveSessionAsync(UserTokenSession session)
        {
            await _tokenSessionAdapter.SaveSessionAsync(session);
        }
    }
}
