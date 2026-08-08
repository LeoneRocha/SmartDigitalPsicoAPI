namespace SmartDigitalPsico.Domain.Hypermedia.Filters
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    [AttributeUsage(AttributeTargets.Class, Inherited = true)]
    public class HyperMediaFilterrAttribute : SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Filters.HyperMediaFilterrAttribute
    {
        public HyperMediaFilterrAttribute(SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Filters.HyperMediaFilterOptions hyperMediaFilterOptions)
            : base(hyperMediaFilterOptions) { }
    }
}
