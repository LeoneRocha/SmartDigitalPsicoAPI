using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.VO;

namespace SmartDigitalPsicoAPI.Core.SDK.Domain.VO
{
    /// <summary>
    /// Classe responsável por ServiceResponse.
    /// Responsabilidade: value object / objeto de valor de resposta.
    /// Relação: retornado pelos Services para Controllers.
    /// </summary>
    public class ServiceResponse<T> : IServiceResponse<T>
    { 
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
        public List<ErrorResponse> Errors { get; set; } = new List<ErrorResponse>();
        public bool Unauthorized { get; set; }
    }  
}
