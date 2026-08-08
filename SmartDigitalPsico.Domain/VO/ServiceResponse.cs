using SmartDigitalPsico.Domain.Interfaces.VO;

namespace SmartDigitalPsico.Domain.VO
{
    /// <summary>
    /// Classe responsável por ServiceResponse.
    /// Responsabilidade: value object / objeto de valor de resposta.
    /// Relação: retornado pelos Services para Controllers.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class ServiceResponse<T> : IServiceResponse<T>
    { 
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
        public List<ErrorResponse> Errors { get; set; } = new List<ErrorResponse>();
        public bool Unauthorized { get; set; }
    }  
}
