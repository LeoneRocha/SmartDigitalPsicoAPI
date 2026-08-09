namespace SmartDigitalPsico.Domain.DTO.Common
{
    /// <summary>
    /// Classe responsável por AppInformationVersionProductDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class AppInformationVersionProductDto
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
        public string EnvironmentName { get; set; } = string.Empty;
        public string Message { get; internal set; } = string.Empty;
    }
}
