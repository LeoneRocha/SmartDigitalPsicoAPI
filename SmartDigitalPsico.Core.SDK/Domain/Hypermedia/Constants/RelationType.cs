using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Hypermedia.Constants;

namespace SmartDigitalPsico.Core.SDK.Domain.Hypermedia.Constants;

/// <summary>
/// Casca RelationType — forward SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Hypermedia.Constants.RelationType",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper forward const RelationType.")]
public static class RelationType
{
    public const string self = Sch.RelationType.self;
    public const string post = Sch.RelationType.post;
    public const string put = Sch.RelationType.put;
    public const string delete = Sch.RelationType.delete;
    public const string patch = Sch.RelationType.patch;
    public const string next = Sch.RelationType.next;
    public const string previous = Sch.RelationType.previous;
    public const string first = Sch.RelationType.first;
    public const string last = Sch.RelationType.last;
}
