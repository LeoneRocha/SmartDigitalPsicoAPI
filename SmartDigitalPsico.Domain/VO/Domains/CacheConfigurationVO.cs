using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.VO.Domains
{
    public class CacheConfigurationVO
    {
        public int AbsoluteExpirationInHours { get; set; }
        public int SlidingExpirationInMinutes { get; set; }
        public int AbsoluteExpirationInMinutes { get; set; }

        public string PathCache { get; set; } = string.Empty;   

        public string ExtensionCache { get; set; } = string.Empty;
        public bool IsEnable { get; set; }
        public ETypeLocationCache TypeCache { get; set; }
    }
}
