using AutoMapper;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces.Mapping;
using Sch = SmartCoreHub.Core.SDK.Infrastructure.Mapping;

namespace SmartDigitalPsico.Core.SDK.Infrastructure.Mapping;

/// <summary>
/// Adapter AutoMapper — casca herdando SCH (EVO.6).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Mapping.AutoMapperAppMapperAdapter",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "EVO.6: herda AutoMapperAppMapperAdapter SCH.")]
public sealed class AutoMapperAppMapperAdapter : Sch.AutoMapperAppMapperAdapter, IAppMapper
{
    public AutoMapperAppMapperAdapter(IMapper mapper)
        : base(mapper)
    {
    }
}
