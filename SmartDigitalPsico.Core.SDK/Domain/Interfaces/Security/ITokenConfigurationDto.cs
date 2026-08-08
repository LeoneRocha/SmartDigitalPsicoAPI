namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security
{
    /// <summary>
    /// Interface (contrato) responsável por ITokenConfigurationDto.
    /// Responsabilidade: segurança e autenticação.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface ITokenConfigurationDto
    {
        string Audience { get; set; }
        string Issuer { get; set; }
        string Secret { get; set; }
        int Minutes { get; set; }
        int DaysToExpiry { get; set; }
    }
}
