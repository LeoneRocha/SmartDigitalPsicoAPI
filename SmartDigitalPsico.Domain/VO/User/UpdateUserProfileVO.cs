using SmartDigitalPsico.Domain.VO.Contracts;
using SmartDigitalPsico.Domain.VO.Medical;

namespace SmartDigitalPsico.Domain.VO.User
{
    public class UpdateUserProfileVO : EntityVOBaseName
    {

        #region Relationship 
        public UpdateMedicalVO? Medical { get; set; }

        #endregion Relationship

        #region Columns  
        public string? Password { get; set; }

        public string? Language { get; set; }

        public string? TimeZone { get; set; }

        #endregion Columns 


    }
}