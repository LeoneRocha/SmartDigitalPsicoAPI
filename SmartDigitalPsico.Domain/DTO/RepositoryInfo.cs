namespace SmartDigitalPsico.Domain.DTO
{
    /// <summary>
    /// Classe responsável por SmartDigitalPsico.Core.SDK.Domain.DTO.RepositoryInfo.
    /// Responsabilidade: DTO de transferência de dados entre camadas da API.
    /// Relação: usado por Controllers, Services e Validators.
    /// </summary>
        // Movido para SmartDigitalPsico.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class RepositoryInfo
    {
        public Type? InterfaceType { get; set; }
        public Type? ImplementationType { get; set; }
    }
}
