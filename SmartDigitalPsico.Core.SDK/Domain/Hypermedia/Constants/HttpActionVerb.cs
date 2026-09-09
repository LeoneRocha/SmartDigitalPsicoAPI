using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Hypermedia.Constants;

namespace SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Constants;

/// <summary>
/// Casca constantes HTTP verb — forward SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Hypermedia.Constants.HttpActionVerb",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper forward const HttpActionVerb.")]
public static class HttpActionVerb
{
    public const string GET = Sch.HttpActionVerb.GET;
    public const string POST = Sch.HttpActionVerb.POST;
    public const string PUT = Sch.HttpActionVerb.PUT;
    public const string DELETE = Sch.HttpActionVerb.DELETE;
    public const string PATCH = Sch.HttpActionVerb.PATCH;
}
