namespace SmartDigitalPsico.Domain.Interfaces.Service
{
    [Obsolete("Use SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.IEntityBaseService instead.")]
    public interface IEntityBaseService<TEntity, TEntityResult> : SmartDigitalPsico.Core.SDK.Domain.Interfaces.Service.IEntityBaseService<TEntity, TEntityResult>
        where TEntity : SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityBase, SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityBaseLog
        where TEntityResult : class
    {
    }
}

