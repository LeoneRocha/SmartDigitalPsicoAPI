using SmartDigitalPsico.Core.SDK.Domain.Interfaces;
using SmartDigitalPsico.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service
{
    /// <summary>
    /// Contrato CRUD genÃ©rico (mÃ¡x. 2 parÃ¢metros de tipo â€” Sonar S2436).
    /// Add/Update usam IEntityDtoAdd / IEntityDto para nÃ£o multiplicar genÃ©ricos.
    /// </summary>
    public interface IEntityBaseService<TEntity, TEntityResult>
    {
        /// <summary>
        /// MÃ©todo Create: cria ou persiste um novo registro/recurso.
        /// </summary>
        Task<ServiceResponse<TEntityResult>> Create(IEntityDtoAdd item);
        /// <summary>
        /// MÃ©todo FindByID: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<TEntityResult>> FindByID(long id);
        /// <summary>
        /// MÃ©todo FindAll: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<List<TEntityResult>>> FindAll();
        /// <summary>
        /// MÃ©todo Update: atualiza um registro/recurso existente.
        /// </summary>
        Task<ServiceResponse<TEntityResult>> Update(IEntityDto item);
        /// <summary>
        /// MÃ©todo Delete: remove ou cancela um registro/recurso.
        /// </summary>
        Task<ServiceResponse<bool>> Delete(long id);
        /// <summary>
        /// MÃ©todo EnableOrDisable: executa a operaÃ§Ã£o EnableOrDisable.
        /// </summary>
        Task<ServiceResponse<bool>> EnableOrDisable(long id);
        /// <summary>
        /// MÃ©todo Exists: valida regras ou verifica existÃªncia.
        /// </summary>
        Task<ServiceResponse<bool>> Exists(long id);
        /// <summary>
        /// MÃ©todo GetCount: consulta e retorna dados.
        /// </summary>
        Task<ServiceResponse<int>> GetCount();

        /// <summary>
        /// MÃ©todo SetUserId: configura estado ou dependÃªncias.
        /// </summary>
        void SetUserId(long id);
        /// <summary>
        /// MÃ©todo Validate: valida regras ou verifica existÃªncia.
        /// </summary>
        Task<ServiceResponse<TEntityResult>> Validate(TEntity item);
    }
}


