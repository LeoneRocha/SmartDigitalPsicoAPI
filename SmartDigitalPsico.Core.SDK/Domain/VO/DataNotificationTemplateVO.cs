using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Domain.VO;

/// <summary>
/// Casca DataNotificationTemplateVO — herda SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.VO.DataNotificationTemplateVO",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper herdando DataNotificationTemplateVO em SmartCoreHub.Core.SDK.")]
public class DataNotificationTemplateVO : SmartCoreHub.Core.SDK.Domain.VO.DataNotificationTemplateVO
{
    public DataNotificationTemplateVO()
    {
    }

    public DataNotificationTemplateVO(string subject, string body) : base(subject, body)
    {
    }
}
