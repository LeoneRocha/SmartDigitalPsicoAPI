namespace SmartDigitalPsico.Domain.Hypermedia.Constants
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HYPER")]
    public static class RelationType
    {
        public const string self = SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Constants.RelationType.self;
        public const string post = SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Constants.RelationType.post;
        public const string put = SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Constants.RelationType.put;
        public const string delete = SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Constants.RelationType.delete;
        public const string patch = SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Constants.RelationType.patch;
        public const string next = SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Constants.RelationType.next;
        public const string previous = SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Constants.RelationType.previous;
        public const string first = SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Constants.RelationType.first;
        public const string last = SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Constants.RelationType.last;
    }
}
