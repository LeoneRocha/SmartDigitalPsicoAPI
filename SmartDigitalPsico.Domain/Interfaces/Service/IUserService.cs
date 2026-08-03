using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.User;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    /// <summary>
    /// Interface (contrato) responsável por IUserService.
    /// Responsabilidade: contrato de serviço de negócio.
    /// Relação: implementado na camada Service e consumido pelos Controllers.
    /// </summary>
    public interface IUserService : IEntityBaseService<User, AddUserDto, UpdateUserDto, GetUserDto>
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
