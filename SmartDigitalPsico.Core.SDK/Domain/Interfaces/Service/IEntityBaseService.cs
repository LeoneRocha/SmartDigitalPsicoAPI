using SmartDigitalPsico.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service
{
    /// <summary>
    /// Contrato CRUD genérico (máx. 2 parâmetros de tipo — Sonar S2436).
    /// Add/Update usam IEntityDtoAdd / IEntityDto para não multiplicar genéricos.
    /// </summary>
    public interface IEntityBaseService<TEntity, TEntityResult>
    {
        /// <summary>
        /// Operação Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        Task<ServiceResponse<TEntityResult>> Create(IEntityDtoAdd item);
        /// <summary>
        /// Operação FindByID: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<TEntityResult>> FindByID(long id);
        /// <summary>
        /// Operação FindAll: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<List<TEntityResult>>> FindAll();
        /// <summary>
        /// Operação Update: atualiza um registro/recurso existente.
        /// </summary>
        Task<ServiceResponse<TEntityResult>> Update(IEntityDto item);
        /// <summary>
        /// Operação Delete: remove ou cancela um registro/recurso.
        /// </summary>
        Task<ServiceResponse<bool>> Delete(long id);
        /// <summary>
        /// Operação EnableOrDisable: executa a operação EnableOrDisable.
        /// </summary>
        Task<ServiceResponse<bool>> EnableOrDisable(long id);
        /// <summary>
        /// Operação Exists: valida regras ou verifica existência.
        /// </summary>
        Task<ServiceResponse<bool>> Exists(long id);
        /// <summary>
        /// Operação GetCount: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<int>> GetCount();

        /// <summary>
        /// Operação SetUserId: configura estado ou dependências.
        /// </summary>
        void SetUserId(long id);
        /// <summary>
        /// Operação Validate: valida regras ou verifica existência.
        /// </summary>
        Task<ServiceResponse<TEntityResult>> Validate(TEntity item);
    }
}

