using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interface (contrato) responsável por IUserTokenSessionRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IUserTokenSessionRepository : IEntityBaseRepository<UserTokenSession>
    {
        /// <summary>
        /// Método GetSessionAsync: consulta e retorna dados.
        /// </summary>
        Task<UserTokenSession?> GetSessionAsync(long userId);

        /// <summary>
        /// Método SaveSessionAsync: cria ou persiste um novo registro/recurso.
        /// </summary>
        Task SaveSessionAsync(UserTokenSession session);
    }
} 
