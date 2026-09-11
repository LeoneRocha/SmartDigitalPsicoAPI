using Microsoft.EntityFrameworkCore.ChangeTracking;
using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Infrastructure.Data;

namespace SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper;

/// <summary>
/// Casca CollectionValueComparerHelper — delega ao SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Data.CollectionValueComparerHelper",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper delegando CollectionValueComparerHelper ao SCH.")]
public static class CollectionValueComparerHelper
{
    public static ValueComparer<T[]> ForArray<T>()
        => Sch.CollectionValueComparerHelper.ForArray<T>();

    public static ValueComparer<T[]> ForJsonArray<T>()
        => Sch.CollectionValueComparerHelper.ForJsonArray<T>();
}
