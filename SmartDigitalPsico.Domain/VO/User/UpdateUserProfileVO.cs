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
        public string Password { get; set; } = string.Empty;

        public string Language { get; set; } = string.Empty;

        public string TimeZone { get; set; } = string.Empty;

        #endregion Columns 


    }
}