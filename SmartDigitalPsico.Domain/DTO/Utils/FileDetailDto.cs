namespace SmartDigitalPsico.Domain.DTO.Utils
{
    /// <summary>
    /// Classe responsável por FileDetailDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class FileDetailDto
    {
        public string DocumentName { get; set; } = string.Empty;
        public string DocType { get; set; } = string.Empty;
        public string DocUrl { get; set; } = string.Empty;
    }
}
