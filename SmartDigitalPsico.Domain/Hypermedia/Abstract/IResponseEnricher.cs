using Microsoft.AspNetCore.Mvc.Filters;

namespace SmartDigitalPsico.Domain.Hypermedia.Abstract
{
    /// <summary>
    /// Interface (contrato) responsável por IResponseEnricher.
    /// Responsabilidade: suporte a hypermedia/HATEOAS nas respostas.
    /// Relação: usado pelos Controllers na serialização.
    /// </summary>
        // Movido para SmartDigitalPsico.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface IResponseEnricher
    {
        /// <summary>
        /// Método CanEnrich: executa a operação CanEnrich.
        /// </summary>
        bool CanEnrich(ResultExecutingContext context);
        /// <summary>
        /// Método Enrich: executa a operação Enrich.
        /// </summary>
        Task Enrich(ResultExecutingContext context);
    }
}
