using IEntityBase = SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityBase;

namespace SmartDigitalPsico.Domain.Interfaces.Repository
{
    /// <summary>
    /// Shim Obsolete — use SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public interface IEntityBaseRepository<T> : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository<T>
        where T : IEntityBase
    {
    }
}
