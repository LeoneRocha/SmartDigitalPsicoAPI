namespace SmartDigitalPsico.Domain.Interfaces.VO
{
    /// <summary>
    /// Interface (contrato) responsável por IServiceResponse.
    /// Responsabilidade: value object / objeto de valor de resposta.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface IServiceResponse<T>
    {
        T? Data { get; set; }
        bool Success { get; set; }
        string Message { get; set; }
    }
}
