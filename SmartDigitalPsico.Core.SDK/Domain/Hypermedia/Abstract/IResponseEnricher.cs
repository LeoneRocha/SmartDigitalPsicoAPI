using Microsoft.AspNetCore.Mvc.Filters;

namespace SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract
{
    /// <summary>
    /// Interface (contrato) responsável por IResponseEnricher.
    /// Responsabilidade: suporte a hypermedia/HATEOAS nas respostas.
    /// Relação: usado pelos Controllers na serialização.
    /// </summary>
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
