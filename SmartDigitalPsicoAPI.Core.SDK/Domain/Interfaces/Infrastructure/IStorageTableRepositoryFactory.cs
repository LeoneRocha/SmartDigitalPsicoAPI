using SmartDigitalPsicoAPI.Core.SDK.Domain.Enuns;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.TableEntity;
using SmartDigitalPsicoAPI.Core.SDK.Domain.TableEntityNoSQL;

namespace SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Infrastructure
{
    /// <summary>
    /// Interface (contrato) responsável por IStorageTableRepositoryFactory.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IStorageTableRepositoryFactory
    {
        IStorageTableContract<T> Create<T>(EStorageAdapterType eStorageAdapterType, string tableName) where T : BaseEntityTable, new();
    }
}
