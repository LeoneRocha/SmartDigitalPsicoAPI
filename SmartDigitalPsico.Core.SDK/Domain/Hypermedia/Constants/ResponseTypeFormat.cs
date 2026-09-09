using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Hypermedia.Constants;

namespace SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Constants;

/// <summary>
/// Casca ResponseTypeFormat — forward SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Hypermedia.Constants.ResponseTypeFormat",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper forward const ResponseTypeFormat.")]
public static class ResponseTypeFormat
{
    public const string DefaultGet = Sch.ResponseTypeFormat.DefaultGet;
    public const string DefaultPost = Sch.ResponseTypeFormat.DefaultPost;
    public const string DefaultPut = Sch.ResponseTypeFormat.DefaultPut;
    public const string DefaultPatch = Sch.ResponseTypeFormat.DefaultPatch;
}
