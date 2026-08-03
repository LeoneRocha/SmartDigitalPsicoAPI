using SmartDigitalPsico.Domain.Hypermedia.Abstract;

namespace SmartDigitalPsico.Domain.Hypermedia.Utils
{
    /// <summary>
    /// Classe responsável por PagedSearchVO.
    /// Responsabilidade: value object / objeto de valor de resposta.
    /// Relação: retornado pelos Services para Controllers.
    /// </summary>
    public class PagedSearchVO<T> where T : ISupportsHyperMedia
    {
        public int CurrentPage { get; private set; }
        public int PageSize { get; private set; }
        public int TotalResults { get; set; }
        public string? SortFields { get; private set; }
        public string? SortDirections { get; private set; }

        public Dictionary<string, object>? Filters { get; private set; }

        public List<T>? List { get; set; }

        /// <summary>
        /// Método PagedSearchVO: executa a operação PagedSearchVO.
        /// </summary>
        public PagedSearchVO() { }

        /// <summary>
        /// Método PagedSearchVO: executa a operação PagedSearchVO.
        /// </summary>
        public PagedSearchVO(int currentPage, int pageSize, string sortFields, string sortDirections)
        {
            CurrentPage = currentPage;
            PageSize = pageSize;
            SortFields = sortFields;
            SortDirections = sortDirections;
        }

        /// <summary>
        /// Método PagedSearchVO: executa a operação PagedSearchVO.
        /// </summary>
        public PagedSearchVO(int currentPage, int pageSize, string sortFields, string sortDirections, Dictionary<string, object> filters)
        {
            CurrentPage = currentPage;
            PageSize = pageSize;
            SortFields = sortFields;
            SortDirections = sortDirections;
            Filters = filters;
        }

        /// <summary>
        /// Método PagedSearchVO: executa a operação PagedSearchVO.
        /// </summary>
        public PagedSearchVO(int currentPage, string sortFields, string sortDirections)
            : this(currentPage, 10, sortFields, sortDirections) { }

        /// <summary>
        /// Método GetCurrentPage: consulta e retorna dados.
        /// </summary>
        public int GetCurrentPage()
        {
            return CurrentPage == 0 ? 2 : CurrentPage;
        }
        /// <summary>
        /// Método GetPageSize: consulta e retorna dados.
        /// </summary>
        public int GetPageSize()
        {
            return PageSize == 0 ? 10 : PageSize;
        }
    }
}
