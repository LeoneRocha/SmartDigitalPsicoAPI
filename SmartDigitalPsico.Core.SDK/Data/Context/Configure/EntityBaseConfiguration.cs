using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using Sch = SmartCoreHub.Core.SDK.Infrastructure.Data;
using SchCommon = SmartCoreHub.Core.SDK.Common;

namespace SmartDigitalPsico.Core.SDK.Data.Context.Configure;

/// <summary>
/// Casca EntityBaseConfiguration — herda SCH; expõe <see cref="ETypeDataBase"/> da casca (espelho int).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Data.EntityBaseConfiguration`1",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "AJ.1: herda SCH EntityBaseConfiguration; ETypeDataBase casca (valores int idênticos).")]
public abstract class EntityBaseConfiguration<T> : Sch.EntityBaseConfiguration<T>
    where T : class
{
    /// <summary>Inicializa com o tipo de banco alvo da casca SDP.</summary>
    protected EntityBaseConfiguration(ETypeDataBase eTypeDataBase)
        : base((SchCommon.ETypeDataBase)(int)eTypeDataBase)
    {
        ETypeDataBase = eTypeDataBase;
    }

    /// <summary>Tipo de banco da casca (espelho de <see cref="SchCommon.ETypeDataBase"/>).</summary>
    protected new ETypeDataBase ETypeDataBase { get; }
}
