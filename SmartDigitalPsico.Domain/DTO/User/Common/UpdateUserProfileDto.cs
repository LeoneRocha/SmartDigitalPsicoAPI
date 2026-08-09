using SmartDigitalPsico.Domain.DTO.Medical.UPDATE;

namespace SmartDigitalPsico.Domain.DTO.User.Common
{
    /// <summary>
    /// Classe responsável por UpdateUserProfileDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class UpdateUserProfileDto : SmartDigitalPsico.Core.SDK.Domain.DTO.Contracts.EntityDtoBaseName
    {
        #region Relationship 
        public UpdateMedicalDto? Medical { get; set; }
        #endregion Relationship

        #region Columns  
        public string Password { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public string TimeZone { get; set; } = string.Empty;
        #endregion Columns 
    }
}
