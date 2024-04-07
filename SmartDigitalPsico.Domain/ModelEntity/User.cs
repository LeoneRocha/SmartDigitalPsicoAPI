using SmartDigitalPsico.Domain.Contracts;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class User : EntityBaseWithNameEmail
    {
        public User()
        {
            RoleGroups = new List<RoleGroup>();
            MedicalsCreateds = new List<Medical>();
            MedicalModifies = new List<Medical>();
            MedicalsUsers = new List<Medical>();
        }
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
        public ICollection<RoleGroup> RoleGroups { get; set; }
        public ICollection<Medical> MedicalsCreateds { get; set; }
        public ICollection<Medical> MedicalModifies { get; set; }
        public ICollection<Medical> MedicalsUsers { get; set; }
        public Medical? Medical { get; set; }
        public long? MedicalId { get; set; }
        #endregion Relationship
    }
}