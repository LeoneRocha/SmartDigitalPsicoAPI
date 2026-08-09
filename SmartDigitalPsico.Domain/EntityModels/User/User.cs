namespace SmartDigitalPsico.Domain.EntityModels
{
    /// <summary>
    /// Classe responsável por User.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
    public class User : SmartDigitalPsico.Core.SDK.Domain.Contracts.EntityBaseWithNameEmail
    {
        /// <summary>
        /// Método User: executa a operação User.
        /// </summary>
        public User()
        {
            MedicalsCreateds = new List<Medical>();
            MedicalModifies = new List<Medical>();
            MedicalsUsers = new List<Medical>();
            UserRoleGroups = new List<RoleGroupUser>();
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
        public ICollection<Medical> MedicalsCreateds { get; set; }
        public ICollection<Medical> MedicalModifies { get; set; }
        public ICollection<Medical> MedicalsUsers { get; set; }
        public Medical? Medical { get; set; }
        public long? MedicalId { get; set; }
        public ICollection<RoleGroupUser> UserRoleGroups { get; set; }

        public UserTokenSession? TokenSession { get; set; }

        #endregion Relationship
    }
}
