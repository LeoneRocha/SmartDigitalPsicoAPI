namespace SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.SMTP
{
    /// <summary>
    /// Classe responsável por EmailMessageDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
    public class EmailMessageDto
    {
        public string Subject { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public List<string> ToEmails { get; set; } = new List<string>();
    }
} 
