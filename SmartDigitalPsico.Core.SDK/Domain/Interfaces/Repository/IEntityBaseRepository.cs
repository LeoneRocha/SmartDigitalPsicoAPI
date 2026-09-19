using System.Linq.Expressions;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Interfaces;
using Sch = SmartCoreHub.Core.SDK.Domain.Interfaces.Repository;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Repository;

/// <summary>
/// Casca IEntityBaseRepository — herda o contrato SCH já portado.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Interfaces.Repository.IEntityBaseRepository`1",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "AJ.1: casca/wrapper herdando IEntityBaseRepository do SCH.")]
public interface IEntityBaseRepository<T> : Sch.IEntityBaseRepository<T>
    where T : IEntityBase
{
}
