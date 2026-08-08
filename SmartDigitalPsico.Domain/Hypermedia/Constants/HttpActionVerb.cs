namespace SmartDigitalPsico.Domain.Hypermedia.Constants
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HYPER")]
    public static class HttpActionVerb
    {
        public const string GET = SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Constants.HttpActionVerb.GET;
        public const string POST = SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Constants.HttpActionVerb.POST;
        public const string PUT = SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Constants.HttpActionVerb.PUT;
        public const string DELETE = SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Constants.HttpActionVerb.DELETE;
        public const string PATCH = SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Constants.HttpActionVerb.PATCH;
    }
}
