using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Service.Infrastructure
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_REPO")]
    public class StorageTableEntityService<T> : SmartDigitalPsico.Core.SDK.Service.Infrastructure.StorageTableEntityService<T>, IStorageTableContract<T>
        where T : BaseEntityTable, new()
    {
        public StorageTableEntityService(IStorageTableRepositoryFactory storageTableRepositoryFactory, string tableName)
            : base(storageTableRepositoryFactory, tableName) { }
    }
}
