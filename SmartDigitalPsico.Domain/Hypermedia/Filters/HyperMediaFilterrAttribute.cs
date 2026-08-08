using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SmartDigitalPsico.Domain.Hypermedia.Filters
{
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    /// <summary>
    /// Classe responsÃ¡vel por HyperMediaFilterrAttribute.
    /// Responsabilidade: suporte a hypermedia/HATEOAS nas respostas.
    /// RelaÃ§Ã£o: usado pelos Controllers na serializaÃ§Ã£o.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class HyperMediaFilterrAttribute : ResultFilterAttribute
    {
        private readonly SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.Filters.HyperMediaFilterOptions _hyperMediaFilterOptions;

        /// <summary>
        /// MÃ©todo HyperMediaFilterrAttribute: executa a operaÃ§Ã£o HyperMediaFilterrAttribute.
        /// </summary>
        public HyperMediaFilterrAttribute(SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.Filters.HyperMediaFilterOptions hyperMediaFilterOptions)
        {
            _hyperMediaFilterOptions = hyperMediaFilterOptions;
        }

        /// <summary>
        /// MÃ©todo OnResultExecuting: executa a operaÃ§Ã£o OnResultExecuting.
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
