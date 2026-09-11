using System.Reflection;
using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Helpers;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers;

/// <summary>
/// Casca ReflectionHelpers — delega ao SCH (OrderAttribute herda SCH).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Helpers.ReflectionHelpers",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper delegando ReflectionHelpers ao SCH.")]
public static class ReflectionHelpers
{
    public static IOrderedEnumerable<PropertyInfo> GetProperties(object dataObject, List<string> propertiesToIgnore)
        => Sch.ReflectionHelpers.GetProperties(dataObject, propertiesToIgnore);

    public static string GetLabelProperty(PropertyInfo property)
        => Sch.ReflectionHelpers.GetLabelProperty(property);
}
