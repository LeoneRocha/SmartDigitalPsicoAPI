using UserEntity = SmartDigitalPsico.Domain.EntityModels.User;

namespace SmartDigitalPsico.Domain.Interfaces.User
{
    /// <summary>
    /// Interface (contrato) responsável por IUserRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IUserRepository : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<UserEntity>
    {
        /// <summary>
        /// Método FindByEmail: consulta e retorna dados.
        /// </summary>
        Task<UserEntity?> FindByEmail(string value);
        /// <summary>
        /// Método FindByLogin: consulta e retorna dados.
        /// </summary>
        Task<UserEntity?> FindByLogin(string login);
        /// <summary>
        /// Método RefreshUserInfo: executa a operação RefreshUserInfo.
        /// </summary>
        Task<UserEntity> RefreshUserInfo(UserEntity user);
        /// <summary>
        /// Método UserExists: executa a operação UserExists.
        /// </summary>
        Task<bool> UserExists(string login);
    }
}
