using System;
using SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    [Obsolete("Use SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Service.IEntityBaseService instead.")]
    public interface IEntityBaseService<TEntity, TEntityResult> : SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<TEntity, TEntityResult>
        where TEntity : SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.IEntityBase, SmartDigitalPsicoAPI.Core.SDK.Domain.Interfaces.IEntityBaseLog
        where TEntityResult : class
    {
    }
}

