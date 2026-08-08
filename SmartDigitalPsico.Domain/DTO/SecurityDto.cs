namespace SmartDigitalPsico.Domain.Security
{
    /// <summary>
    /// Classe responsável por SecurityDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class SecurityDto
    {
        public string Name { get;   set; } = string.Empty;
        public string Role { get;   set; } = string.Empty;
        public string Id { get; internal set; } = string.Empty;
        public string SecurityKeyConfig { get; set; } = string.Empty;
    }
}
