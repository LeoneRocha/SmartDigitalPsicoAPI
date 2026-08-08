using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.TableEntity;
using SmartDigitalPsicoAPI.Core.SDK.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Data.TableEntityRepository
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsicoAPI.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsicoAPI.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_REPO")]
    public class GenericTableEntityRepository<T> : SmartDigitalPsicoAPI.Core.SDK.Data.TableEntityRepository.GenericTableEntityRepository<T>
        where T : BaseEntityTable, new()
    {
        public GenericTableEntityRepository(IStorageTableContract<T> tableStorageAdapter, string tableName)
            : base(tableStorageAdapter, tableName)
        {
        }
    }
}
