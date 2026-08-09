namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.VO
{
    /// <summary>
    /// Interface (contrato) responsável por IServiceResponse.
    /// Responsabilidade: value object / objeto de valor de resposta.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IServiceResponse<T>
    {
        T? Data { get; set; }
        bool Success { get; set; }
        string Message { get; set; }
    }
}
