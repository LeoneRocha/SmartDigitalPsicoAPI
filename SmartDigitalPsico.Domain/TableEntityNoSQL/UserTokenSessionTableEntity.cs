namespace SmartDigitalPsico.Domain.TableEntityNoSQL
{
    /// <summary>
    /// Classe responsável por UserTokenSessionTableEntity.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class UserTokenSessionTableEntity : BaseEntityTable
    {
        public string AccessToken { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime RefreshTokenExpiryTime { get; set; }
        public DateTime ExpiresAt { get; set; } 
        public DateTime CreatedDate { get; set; }
        public DateTime ModifyDate { get; set; }  
        public long UserId { get; set; }
    }
}
