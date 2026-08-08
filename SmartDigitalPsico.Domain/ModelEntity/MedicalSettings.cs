using EntityBase = SmartDigitalPsico.Core.SDK.Domain.Contracts.EntityBase;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    /// <summary>
    /// Classe responsável por MedicalSettings.
    /// Responsabilidade: entidade de domínio persistida via EF Core.
    /// Relação: mapeada no Data Context e usada pelos repositórios.
    /// </summary>
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
