namespace SmartDigitalPsico.Domain.DTO.Application.Common
{
    /// <summary>
    /// Classe responsável por AppConfigurationSettingDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AppConfigurationSettingDto
    {
        public string PathCache { get; set; } = string.Empty;
    }
}
