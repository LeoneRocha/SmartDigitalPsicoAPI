using SmartDigitalPsico.Domain.VO.Contracts;

namespace SmartDigitalPsico.Domain.VO.User
{
    public class UpdateUserVO : EntityVOBaseName
    {

        #region Relationship
        public List<long>? RoleGroupsIds { get; set; }

        public long? MedicalId { get; set; }

        #endregion Relationship

        #region Columns  
        public string? Password { get; set; }

        public string? Role { get; set; }

        public bool? Admin { get; set; }

        public string? Language { get; set; }

        public string? TimeZone { get; set; }

        #endregion Columns 


    }
}