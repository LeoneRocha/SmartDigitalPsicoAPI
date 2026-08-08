using SmartDigitalPsico.Core.SDK.Data.Context.Interface;
using SmartDigitalPsico.Core.SDK.Domain.Contracts;

namespace SmartDigitalPsico.Data.Repository.Generic
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// Aceita IEntityDataContext (produção: EntityDataContext : DbContext; testes: mock).
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_REPO")]
    public abstract class GenericRepositoryEntityBase<T> : SmartDigitalPsico.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<T>
        where T : EntityBase
    {
        protected GenericRepositoryEntityBase(IEntityDataContext context)
            : base(context)
        {
        }
    }
}
