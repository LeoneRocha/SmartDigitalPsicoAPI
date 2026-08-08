using SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Abstract;

namespace SmartDigitalPsico.Domain.Hypermedia.Utils
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HYPER")]
    public class PagedSearchVO<T> : SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Utils.PagedSearchVO<T>
        where T : ISupportsHyperMedia
    {
        public PagedSearchVO() { }

        public PagedSearchVO(int currentPage, int pageSize, string sortFields, string sortDirections)
            : base(currentPage, pageSize, sortFields, sortDirections) { }

        public PagedSearchVO(int currentPage, int pageSize, string sortFields, string sortDirections, Dictionary<string, object> filters)
            : base(currentPage, pageSize, sortFields, sortDirections, filters) { }

        public PagedSearchVO(int currentPage, string sortFields, string sortDirections)
            : base(currentPage, sortFields, sortDirections) { }
    }
}
