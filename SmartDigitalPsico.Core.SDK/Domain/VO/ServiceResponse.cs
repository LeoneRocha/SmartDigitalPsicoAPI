using SmartDigitalPsico.Core.SDK.Domain.Interfaces.VO;

namespace SmartDigitalPsico.Core.SDK.Domain.VO
{
    /// <summary>
    /// Classe responsável por ServiceResponse.
    /// Responsabilidade: value object / objeto de valor de resposta.
    /// Relação: retornado pelos Services para Controllers.
    /// Alinhado à matriz SCH: <c>Success</c> deriva de <see cref="Errors"/> (sem setter).
    /// </summary>
    public class ServiceResponse<T> : IServiceResponse<T>
    {
        public T? Data { get; set; }

        /// <summary>
        /// Sucesso quando não há erros (equivalente ao envelope SCH).
        /// </summary>
        public bool Success => Errors == null || Errors.Count == 0;

        public string Message { get; set; } = string.Empty;
        public List<ErrorResponse> Errors { get; set; } = new List<ErrorResponse>();
        public bool Unauthorized { get; set; }
    }
}
