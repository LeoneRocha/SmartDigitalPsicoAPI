using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Domain.Interfaces.TableEntity
{
    /// <summary>
    /// Shim Obsolete — use SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface IStorageTableContract<T> : SmartDigitalPsico.Core.SDK.Domain.Interfaces.TableEntity.IStorageTableContract<T>
        where T : BaseEntityTable, new()
    {
    }
}
