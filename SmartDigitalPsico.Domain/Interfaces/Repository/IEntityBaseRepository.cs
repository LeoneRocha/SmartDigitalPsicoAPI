﻿using SmartDigitalPsico.Domain.Contracts;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    public interface IEntityBaseRepository<T> where T : EntityBase
    {
        Task<T> Create(T item);
        Task<T> FindByID(long id);
        Task<List<T>> FindAll();
        Task<T> Update(T item);
        Task<bool> Delete(long id);
        Task<bool> EnableOrDisable(long id);
        Task<bool> Exists(long id);
        Task<List<T>> FindWithPagedSearch(string query);
        Task<int> GetCount(string query);
    }
}
