using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.VO.Domains
{
    public class AuthConfigurationVO
    {
        public bool IsEnable { get; set; }
        public ETypeApiCredential TypeApiCredential { get; set; }
    }
}
