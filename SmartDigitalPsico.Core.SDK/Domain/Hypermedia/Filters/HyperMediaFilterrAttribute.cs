using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Filters;

/// <summary>
/// Casca HyperMediaFilterrAttribute — lógica alinhada ao SCH; opções SDP.
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = true)]
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Hypermedia.Filters.HyperMediaFilterrAttribute",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca filtro HATEOAS; HyperMediaFilterOptions SDP (typo Filterr preservado).")]
public class HyperMediaFilterrAttribute : ResultFilterAttribute
{
    private readonly HyperMediaFilterOptions _hyperMediaFilterOptions;

    public HyperMediaFilterrAttribute(HyperMediaFilterOptions hyperMediaFilterOptions)
    {
        _hyperMediaFilterOptions = hyperMediaFilterOptions;
    }

    public override void OnResultExecuting(ResultExecutingContext context)
    {
        TryEnrichResult(context);
        base.OnResultExecuting(context);
    }

    private void TryEnrichResult(ResultExecutingContext context)
    {
        if (context.Result is not OkObjectResult)
            return;

        var enricher = _hyperMediaFilterOptions.ContentResponseEnricherList.Find(x => x.CanEnrich(context));
        if (enricher != null)
            _ = enricher.Enrich(context);
    }
}
