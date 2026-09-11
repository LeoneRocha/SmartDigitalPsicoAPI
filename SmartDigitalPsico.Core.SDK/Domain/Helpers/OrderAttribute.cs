using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Helpers;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers;

/// <summary>
/// Casca OrderAttribute — herda SCH.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Helpers.OrderAttribute",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando OrderAttribute do SCH.")]
public class OrderAttribute : Sch.OrderAttribute
{
    public OrderAttribute(int order) : base(order)
    {
    }
}
