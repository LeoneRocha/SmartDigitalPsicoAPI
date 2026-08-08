using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;

namespace SmartDigitalPsico.Domain.Hypermedia
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// Enrichers de domínio continuam no host herdando este tipo (ou o Core).
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HYPER")]
    public abstract class ContentResponseEnricher<T> : SmartDigitalPsico.Core.SDK.Domain.Hypermedia.ContentResponseEnricher<T>
        where T : ISupportsHyperMedia
    {
    }
}
