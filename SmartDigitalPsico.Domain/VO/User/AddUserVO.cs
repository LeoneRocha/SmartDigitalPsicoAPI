using SmartDigitalPsico.Domain.VO.Contracts;

namespace SmartDigitalPsico.Domain.VO.User
{
    public class AddUserVO : EntityVOBaseAdd
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