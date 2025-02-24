using SmartDigitalPsico.Domain.Contracts;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class MedicalSettings : EntityBase
    {
        #region Columns
        public long MedicalId { get; set; }
        public string GoogleCalendarId { get; set; } = string.Empty;
        public string GoogleAccessToken { get; set; } = string.Empty;
        public string GoogleRefreshToken { get; set; } = string.Empty;
        public DateTime GoogleTokenExpiry { get; set; }
        #endregion Columns

        #region Relationship
        public required Medical Medical { get; set; }
        #endregion Relationship
    } 
}
