using Microsoft.AspNetCore.Http;
using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers;

/// <summary>
/// Casca RequestCultureMiddleware — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Helpers.RequestCultureMiddleware",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando RequestCultureMiddleware do SCH.")]
public class RequestCultureMiddleware : SmartCoreHub.Core.SDK.Domain.Helpers.RequestCultureMiddleware
{
    public RequestCultureMiddleware(RequestDelegate next) : base(next)
    {
    }
}
