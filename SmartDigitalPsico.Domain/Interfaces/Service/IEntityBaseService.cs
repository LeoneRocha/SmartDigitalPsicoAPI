using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    /// <summary>
    /// Contrato CRUD genérico (máx. 2 parâmetros de tipo — Sonar S2436).
    /// Add/Update usam IEntityDtoAdd / IEntityDto para não multiplicar genéricos.
    /// </summary>
    public interface IEntityBaseService<TEntity, TEntityResult>
    {
        /// <summary>
        /// Método Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        Task<ServiceResponse<TEntityResult>> Create(IEntityDtoAdd item);
        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<TEntityResult>> FindByID(long id);
        /// <summary>
        /// Método FindAll: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<List<TEntityResult>>> FindAll();
        /// <summary>
        /// Método Update: atualiza um registro/recurso existente.
        /// </summary>
        Task<ServiceResponse<TEntityResult>> Update(IEntityDto item);
        /// <summary>
        /// Método Delete: remove ou cancela um registro/recurso.
        /// </summary>
        Task<ServiceResponse<bool>> Delete(long id);
        /// <summary>
        /// Método EnableOrDisable: executa a operação EnableOrDisable.
        /// </summary>
        Task<ServiceResponse<bool>> EnableOrDisable(long id);
        /// <summary>
        /// Método Exists: valida regras ou verifica existência.
        /// </summary>
        Task<ServiceResponse<bool>> Exists(long id);
        /// <summary>
        /// Método GetCount: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<int>> GetCount();

        /// <summary>
        /// Método SetUserId: configura estado ou dependências.
        /// </summary>
        void SetUserId(long id);
        /// <summary>
        /// Método Validate: valida regras ou verifica existência.
        /// </summary>
        Task<ServiceResponse<TEntityResult>> Validate(TEntity item);
    }
}
