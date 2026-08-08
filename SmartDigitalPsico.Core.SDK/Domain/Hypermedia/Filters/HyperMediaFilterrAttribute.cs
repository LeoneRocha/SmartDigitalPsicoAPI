using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Filters
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    /// <summary>
    /// Classe responsável por HyperMediaFilterrAttribute.
    /// Responsabilidade: suporte a hypermedia/HATEOAS nas respostas.
    /// Relação: usado pelos Controllers na serialização.
    /// </summary>
    public class HyperMediaFilterrAttribute : ResultFilterAttribute
    {
        private readonly HyperMediaFilterOptions _hyperMediaFilterOptions;

        /// <summary>
        /// Método HyperMediaFilterrAttribute: executa a operação HyperMediaFilterrAttribute.
        /// </summary>
        public HyperMediaFilterrAttribute(HyperMediaFilterOptions hyperMediaFilterOptions)
        {
            _hyperMediaFilterOptions = hyperMediaFilterOptions;
        }

        /// <summary>
        /// Método OnResultExecuting: executa a operação OnResultExecuting.
        /// </summary>
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            TryEnrichResult(context);
            base.OnResultExecuting(context);
        }

        private void TryEnrichResult(ResultExecutingContext context)
        {
            if (context.Result is OkObjectResult)
            {
                var enricher = _hyperMediaFilterOptions.ContentResponseEnricherList.Find(x => x.CanEnrich(context));

                if (enricher != null)
                {
                    Task.FromResult(enricher.Enrich(context));
                }
            }
        }
    }
}
