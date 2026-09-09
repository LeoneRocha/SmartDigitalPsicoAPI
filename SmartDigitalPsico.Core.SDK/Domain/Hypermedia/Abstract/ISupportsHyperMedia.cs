using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Hypermedia;

namespace SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;

/// <summary>
/// Contrato HATEOAS — surface SDP com <see cref="HyperMediaLink"/> SDP
/// (não herda SCH: List&lt;T&gt; invariante).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Hypermedia.Abstract.ISupportsHyperMedia",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Espelho de contrato; Links usa HyperMediaLink SDP.")]
public interface ISupportsHyperMedia
{
    List<HyperMediaLink> Links { get; set; }
}
