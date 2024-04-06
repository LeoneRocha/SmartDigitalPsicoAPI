using SmartDigitalPsico.Domain.Contracts;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class User : EntityBaseWithNameEmail
    {
        #region Columns 
        public string Login { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = [];
        public byte[] PasswordSalt { get; set; } = [];
        public string Role { get; set; } = string.Empty;
        public bool Admin { get; set; }
        public string Language { get; set; } = string.Empty;
        public string TimeZone { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime? RefreshTokenExpiryTime { get; set; }
        #endregion Columns 

        #region Relationship
        public List<RoleGroup> RoleGroups { get; set; }
        public List<Medical> MedicalsCreateds { get; set; }
        public List<Medical> MedicalModifies { get; set; }
        public List<Medical> MedicalsUsers { get; set; }
        public Medical? Medical { get; set; }
        public long? MedicalId { get; set; }
        #endregion Relationship
    }
}