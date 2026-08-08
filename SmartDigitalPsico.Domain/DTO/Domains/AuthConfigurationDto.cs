using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Domain.DTO.Domains
{
    /// <summary>
    /// Classe responsável por AuthConfigurationDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AuthConfigurationDto
    {
        public bool IsEnable { get; set; }
        public SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns.ETypeApiCredential TypeApiCredential { get; set; }
    }
}
