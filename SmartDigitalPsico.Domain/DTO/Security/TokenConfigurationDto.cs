using SmartDigitalPsico.Domain.Interfaces.Security;

namespace SmartDigitalPsico.Domain.DTO.Security
{
    public class TokenConfigurationDto : ITokenConfigurationDto
    {
        public string Audience { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Secret { get; set; } = string.Empty;
        public int Minutes { get; set; }
        public int DaysToExpiry { get; set; }
    }
}
