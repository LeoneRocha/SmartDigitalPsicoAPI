using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Core.SDK.Domain.DTO.Domains
{
    /// <summary>
    /// Classe responsável por AuthConfigurationDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AuthConfigurationDto
    {
        public bool IsEnable { get; set; }
        public ETypeApiCredential TypeApiCredential { get; set; }
    }
}

