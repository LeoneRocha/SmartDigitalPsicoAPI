using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Service.Infrastructure.Authentication
{
    /// <summary>
    /// Classe responsável por DatabaseTokenSessionAdapter.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
    public class DatabaseTokenSessionAdapter : ITokenSessionPersistenceAdapter
    {
        private readonly IUserTokenSessionRepository _userTokenSessionRepository;

        /// <summary>
        /// Método DatabaseTokenSessionAdapter: executa a operação DatabaseTokenSessionAdapter.
        /// </summary>
        public DatabaseTokenSessionAdapter(IUserTokenSessionRepository  userTokenSessionRepository)
        {
             _userTokenSessionRepository = userTokenSessionRepository;
        }

        /// <summary>
        /// Método GetSessionAsync: consulta e retorna dados.
        /// </summary>
        public async Task<UserTokenSession?> GetSessionAsync(long userId)
        {
            return await _userTokenSessionRepository.GetSessionAsync(userId);
        }

        /// <summary>
        /// Método SaveSessionAsync: cria ou persiste um novo registro/recurso.
        /// </summary>
        public async Task SaveSessionAsync(UserTokenSession userTokenSession)
        { 
            await _userTokenSessionRepository.SaveSessionAsync(userTokenSession);
        }
    }
}
