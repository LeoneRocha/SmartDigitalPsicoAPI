using SmartDigitalPsico.Domain.Hypermedia.Utils;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    public interface IEntityBaseSimpleService<TEntity, TEntityAdd, TEntityUpdate, TEntityResult>
    {
        Task<ServiceResponse<TEntityResult>> Create(TEntityAdd item);
        Task<ServiceResponse<TEntityResult>> FindByID(long id);
        Task<ServiceResponse<List<TEntityResult>>> FindAll();
        Task<ServiceResponse<TEntityResult>> Update(TEntityUpdate item);
        Task<ServiceResponse<bool>> Delete(long id);
        Task<ServiceResponse<bool>> Exists(long id);
        Task<ServiceResponse<List<TEntityResult>>> FindWithPagedSearch(string query);
        Task<ServiceResponse<int>> GetCount(string query);
        Task<ServiceResponse<bool>> EnableOrDisable(long id);
        void SetUserId(long id);

        Task<ServiceResponse<TEntityResult>> Validate(TEntity item);

    }
}