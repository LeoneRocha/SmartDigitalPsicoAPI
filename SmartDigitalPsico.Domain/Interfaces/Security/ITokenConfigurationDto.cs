namespace SmartDigitalPsico.Domain.Interfaces.Security
{
    /// <summary>
    /// Interface (contrato) responsável por ITokenConfigurationDto.
    /// Responsabilidade: segurança e autenticação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface ITokenConfigurationDto
    {
        string Audience { get; set; }
        string Issuer { get; set; }
        string Secret { get; set; }
        int Minutes { get; set; }
        int DaysToExpiry { get; set; }
    }
}
