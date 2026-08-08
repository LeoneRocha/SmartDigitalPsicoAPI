using AutoMapper;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Mapping;

namespace SmartDigitalPsico.Core.SDK.Infrastructure.Mapping
{
    /// <summary>
    /// Adapter que concentra a dependência de AutoMapper. Único ponto do SDK que referencia AutoMapper.IMapper em runtime de app.
    /// </summary>
    public sealed class AutoMapperAppMapperAdapter : IAppMapper
    {
        private readonly IMapper _mapper;

        public AutoMapperAppMapperAdapter(IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Expõe o IMapper AutoMapper subjacente (bootstrap / testes de perfil).
        /// </summary>
        public IMapper InnerMapper => _mapper;

        public TDestination Map<TDestination>(object source)
            => _mapper.Map<TDestination>(source);

        public TDestination Map<TSource, TDestination>(TSource source)
            => _mapper.Map<TSource, TDestination>(source);

        public TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
            => _mapper.Map(source, destination);
    }
}
