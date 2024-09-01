using SmartDigitalPsico.Domain.Interfaces.Security;

namespace SmartDigitalPsico.Domain.VO.Security
{ 
    public class TokenConfigurationVO : ITokenConfigurationVO
    {
        public string Audience { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Secret { get; set; } = string.Empty;
        public int Minutes { get; set; }
        public int DaysToExpiry { get; set; }
    }
}
