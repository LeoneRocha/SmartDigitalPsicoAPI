using SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.Abstract;

namespace SmartDigitalPsico.Domain.Hypermedia.Utils
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsicoAPI.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsicoAPI.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HYPER")]
    public class PagedSearchVO<T> : SmartDigitalPsicoAPI.Core.SDK.Domain.Hypermedia.Utils.PagedSearchVO<T>
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
