using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Domains
{
    /// <summary>
    /// Classe responsável por CacheConfigurationDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class CacheConfigurationDto
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
