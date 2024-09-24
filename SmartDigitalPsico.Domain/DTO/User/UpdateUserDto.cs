using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.User
{
    public class UpdateUserDto : EntityDtoBaseName
    {

        #region Relationship
        public List<long> RoleGroupsIds { get; set; } = new List<long>();
        public long MedicalId { get; set; }
        #endregion Relationship

        #region Columns  
        public string? Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public bool Admin { get; set; }
        public string Language { get; set; } = string.Empty;
        public string TimeZone { get; set; } = string.Empty;
        #endregion Columns 
    }
}