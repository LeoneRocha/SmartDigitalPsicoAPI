namespace SmartDigitalPsicoAPI.Core.SDK.Domain.DTO
{
    /// <summary>
    /// Classe responsável por TimeZoneDisplayDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class TimeZoneDisplayDto
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
