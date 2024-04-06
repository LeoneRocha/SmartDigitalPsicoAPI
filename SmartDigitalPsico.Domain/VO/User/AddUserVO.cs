using SmartDigitalPsico.Domain.VO.Contracts;

namespace SmartDigitalPsico.Domain.VO.User
{
    public class AddUserVO : EntityVOBaseAdd
    {
        #region Relationship
        public List<long>? RoleGroupsIds { get; set; }

        public long? MedicalId { get; set; }

        #endregion Relationship

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Login { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        #region Columns  

        public string? Role { get; set; }

        public bool? Admin { get; set; }

        public string? Language { get; set; }

        public string? TimeZone { get; set; }


        #endregion Columns 
    }
}