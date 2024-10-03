namespace SmartDigitalPsico.Domain.TableEntityNoSQL
{
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
