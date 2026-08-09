using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Domain.DTO.User.Common;
using SmartDigitalPsico.Domain.DTO.User.GET;
using UserEntity = SmartDigitalPsico.Domain.EntityModels.User;

namespace SmartDigitalPsico.Domain.Interfaces.User
{
    /// <summary>
    /// Interface (contrato) responsável por IUserService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IUserService : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<UserEntity, GetUserDto>
    {
        /// <summary>
        /// Método Login: executa a operação Login.
        /// </summary>
        Task<ServiceResponse<GetUserAuthenticatedDto>> Login(string login, string password);
        /// <summary>
        /// Método Logout: executa a operação Logout.
        /// </summary>
        Task<ServiceResponse<bool>> Logout(string login);

        /// <summary>
        /// Método Register: cria ou persiste um novo registro/recurso.
        /// </summary>
        Task<ServiceResponse<GetUserDto>> Register(UserRegisterDto userRegisterVO);

        /// <summary>
        /// Método UpdateProfile: atualiza um registro/recurso existente.
        /// </summary>
        Task<ServiceResponse<GetUserDto>> UpdateProfile(UpdateUserProfileDto userUpdateProfileVO);
    }
}
