using Microsoft.AspNetCore.Mvc.Filters;
using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;

/// <summary>
/// Contrato enricher HATEOAS — espelho SCH (sem herança para permitir impl explícita local).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Hypermedia.Abstract.IResponseEnricher",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Espelho de contrato ASP.NET ResultExecutingContext.")]
public interface IResponseEnricher
{
    bool CanEnrich(ResultExecutingContext context);
    Task Enrich(ResultExecutingContext context);
}
