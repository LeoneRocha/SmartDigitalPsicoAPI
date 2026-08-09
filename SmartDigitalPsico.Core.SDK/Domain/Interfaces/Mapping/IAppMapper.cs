namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Mapping
{
    /// <summary>
    /// Abstração de mapeamento objeto-objeto. Consumidores devem depender desta interface
    /// (não de AutoMapper.IMapper). Implementação canônica: AutoMapperAppMapperAdapter.
    /// </summary>
    public interface IAppMapper
    {
        TDestination Map<TDestination>(object source);

        TDestination Map<TSource, TDestination>(TSource source);

        TDestination Map<TSource, TDestination>(TSource source, TDestination destination);
    }
}
