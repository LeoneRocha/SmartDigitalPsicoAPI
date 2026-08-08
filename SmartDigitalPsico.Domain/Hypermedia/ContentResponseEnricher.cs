using SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.Abstract;

namespace SmartDigitalPsico.Domain.Hypermedia
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsicoAPI.Core.SDK.
    /// Enrichers de domínio continuam no host herdando este tipo (ou o Core).
    /// </summary>
    // Movido para SmartDigitalPsicoAPI.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HYPER")]
    public abstract class ContentResponseEnricher<T> : SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.ContentResponseEnricher<T>
        where T : ISupportsHyperMedia
    {
    }
}
