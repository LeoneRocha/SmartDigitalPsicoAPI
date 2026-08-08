using SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Core.SDK.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Data.TableEntityRepository
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_REPO")]
    public class GenericTableEntityRepository<T> : SmartDigitalPsico.Core.SDK.Data.TableEntityRepository.GenericTableEntityRepository<T>
        where T : BaseEntityTable, new()
    {
        public GenericTableEntityRepository(IStorageTableContract<T> tableStorageAdapter, string tableName)
            : base(tableStorageAdapter, tableName)
        {
        }
    }
}
