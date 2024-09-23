using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Domain.DTO.Domains
{
    public class AuthConfigurationDto
    {
        public bool IsEnable { get; set; }
        public ETypeApiCredential TypeApiCredential { get; set; }
    }
}
