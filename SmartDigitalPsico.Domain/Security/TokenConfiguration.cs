namespace SmartDigitalPsico.Domain.Security
{
    public interface ITokenConfiguration
    {
        string Audience { get; set; }
        string Issuer { get; set; }
        string Secret { get; set; }
        int Minutes { get; set; }
        int DaysToExpiry { get; set; }
    }
    public class TokenConfiguration : ITokenConfiguration
    {
        public string Audience { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Secret { get; set; } = string.Empty;
        public int Minutes { get; set; }
        public int DaysToExpiry { get; set; }
    }
}
