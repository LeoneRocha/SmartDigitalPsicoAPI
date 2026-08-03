namespace SmartDigitalPsico.Domain.DTO.User
{
    /// <summary>
    /// Classe responsável por UserLoginDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class UserLoginDto
    { 
        public string Login { get; set; } = string.Empty;        
        public string Password { get; set; } = string.Empty;
    }
}
