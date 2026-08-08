using System.Linq.Expressions;

using IEntityBase = SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.IEntityBase;
namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    /// <summary>
    /// Interface (contrato) responsável por IEntityBaseRepository.
    /// Responsabilidade: repositório de persistência.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface IEntityBaseRepository<T> where T : IEntityBase
    {
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        Task<T> Create(T item);
        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        Task<T> FindByID(long id);
        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        Task<T> FindByID(long id, params Expression<Func<T, object>>[] includes);
        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        Task<T> FindByID(long id, Action<IQueryable<T>> includeAction);
        /// <summary>
        /// Método FindAsync: consulta e retorna dados.
        /// </summary>
        Task<T?> FindAsync(long id, params Expression<Func<T, object>>[] includes);
        /// <summary>
        /// Método FindAll: consulta e retorna dados.
        /// </summary>
        Task<List<T>> FindAll();
        /// <summary>
        /// Método FindByCustomWhere: consulta e retorna dados.
        /// </summary>
        Task<List<T>> FindByCustomWhere(Expression<Func<T, bool>> predicate);
        /// <summary>
        /// Método FindByCustomWhereWithIncludes: consulta e retorna dados.
        /// </summary>
        Task<List<T>> FindByCustomWhereWithIncludes(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        /// <summary>
        /// Método FindExistsByID: consulta e retorna dados.
        /// </summary>
        Task FindExistsByID(long id);
        /// <summary>
        /// Método Update: atualiza um registro/recurso existente.
        /// </summary>
        Task<T> Update(T item);
        /// <summary>
        /// Método Delete: remove ou cancela um registro/recurso.
        /// </summary>
        Task<bool> Delete(long id);
        /// <summary>
        /// Método EnableOrDisable: executa a operação EnableOrDisable.
        /// </summary>
        Task<bool> EnableOrDisable(long id);
        /// <summary>
        /// Método Exists: valida regras ou verifica existência.
        /// </summary>
        Task<bool> Exists(long id);
        /// <summary>
        /// Método GetCount: consulta e retorna dados.
        /// </summary>
        Task<int> GetCount(Expression<Func<T, bool>> predicate); 
    }
}
