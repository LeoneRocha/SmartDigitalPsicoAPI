using SmartDigitalPsico.Domain.Contracts;

namespace SmartDigitalPsico.Domain.ModelEntity
{
    public class UserTokenSession : EntityBase
    {
        public string AccessToken { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime RefreshTokenExpiryTime { get; set; }
        public DateTime ExpiresAt { get; set; }

        public long UserId { get; set; }
        public User? User { get; set; }
    }
}
