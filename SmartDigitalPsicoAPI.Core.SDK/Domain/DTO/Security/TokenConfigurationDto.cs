using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Security;

namespace SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.Security
{
    /// <summary>
    /// Classe responsável por TokenConfigurationDto.
    /// Responsabilidade: segurança e autenticação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class TokenConfigurationDto : ITokenConfigurationDto
    {
        public string Audience { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Secret { get; set; } = string.Empty;
        public int Minutes { get; set; }
        public int DaysToExpiry { get; set; }
    }
}
