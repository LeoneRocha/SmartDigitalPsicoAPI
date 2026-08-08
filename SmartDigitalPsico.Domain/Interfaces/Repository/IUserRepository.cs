using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interface (contrato) responsável por IUserRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IUserRepository : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<User>
    {
        /// <summary>
        /// Método FindByEmail: consulta e retorna dados.
        /// </summary>
        Task<User?> FindByEmail(string value);
        /// <summary>
        /// Método FindByLogin: consulta e retorna dados.
        /// </summary>
        Task<User?> FindByLogin(string login);
        /// <summary>
        /// Método RefreshUserInfo: executa a operação RefreshUserInfo.
        /// </summary>
        Task<User> RefreshUserInfo(User user); 
        /// <summary>
        /// Método UserExists: executa a operação UserExists.
        /// </summary>
        Task<bool> UserExists(string login);
    }
}
