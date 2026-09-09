using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;

namespace SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Filters;

/// <summary>
/// Opções do filtro HATEOAS — surface SDP (List de enrichers SDP).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Hypermedia.Filters.HyperMediaFilterOptions",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Espelho de opções; ContentResponseEnricherList tipado com IResponseEnricher SDP.")]
public class HyperMediaFilterOptions
{
    public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new();
}
