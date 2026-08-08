using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.User
{
    /// <summary>
    /// Classe responsável por AddUserDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AddUserDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBaseAdd
    {
        #region Relationship
        public long[] RoleGroupsIds { get; set; } = Array.Empty<long>();
        public long? MedicalId { get; set; }
        #endregion Relationship
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        #region Columns  
        public string Role { get; set; } = string.Empty;
        public bool Admin { get; set; } 
        public string Language { get; set; } = string.Empty;
        public string TimeZone { get; set; } = string.Empty;
        #endregion Columns 
    }
}
