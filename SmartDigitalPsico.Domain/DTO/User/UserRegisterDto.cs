namespace SmartDigitalPsico.Domain.DTO.User
{
    /// <summary>
    /// Classe responsável por UserRegisterDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class UserRegisterDto : AddUserDto
    {
        /// <summary>
        /// Método UserRegisterDto: executa a operação UserRegisterDto.
        /// </summary>
        public UserRegisterDto()
        {
            RoleGroupsIds = Array.Empty<long>();
        }
    }
}
