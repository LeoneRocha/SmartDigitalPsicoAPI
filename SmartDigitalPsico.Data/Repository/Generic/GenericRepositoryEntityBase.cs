using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Contracts;

namespace SmartDigitalPsico.Data.Repository.Generic
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsicoAPI.Core.SDK.
    /// Aceita IEntityDataContext (produção: EntityDataContext : DbContext; testes: mock).
    /// </summary>
    // Movido para SmartDigitalPsicoAPI.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_REPO")]
    public abstract class GenericRepositoryEntityBase<T> : SmartDigitalPsicoAPI.Core.SDK.Data.Repository.Generic.GenericRepositoryEntityBase<T>
        where T : EntityBase
    {
        protected GenericRepositoryEntityBase(IEntityDataContext context)
            : base(context.Set<T>(), context as DbContext)
        {
        }
    }
}
