namespace SmartDigitalPsico.Domain.DTO
{
    /// <summary>
    /// Classe responsável por SmartDigitalPsicoAPI.Core.SDK.Domain.DTO.TimeZoneDisplayDto.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class TimeZoneDisplayDto
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
