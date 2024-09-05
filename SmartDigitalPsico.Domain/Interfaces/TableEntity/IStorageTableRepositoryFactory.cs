using Azure.Data.Tables;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Domain.Interfaces.TableEntity
{
    public interface IStorageTableRepositoryFactory
    {
        IStorageTableEntityRepository<T> Create<T>(EStorageAdapterType eStorageAdapterType, string tableName) where T : BaseEntityTable, new();
    }
}