using SmartDigitalPsico.Domain.DTO.Contracts;
using SmartDigitalPsico.Domain.DTO.Medical;

namespace SmartDigitalPsico.Domain.DTO.User
{
    public class UpdateUserProfileDto : EntityDtoBaseName
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