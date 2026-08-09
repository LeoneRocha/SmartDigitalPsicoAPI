namespace SmartDigitalPsico.Core.SDK.Domain.DTO
{
    /// <summary>
    /// Classe responsável por CultureDisplayDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class CultureDisplayDto
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
