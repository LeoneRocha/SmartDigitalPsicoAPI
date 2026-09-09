using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Notification;

/// <summary>
/// Contrato notificação — surface SDP com <see cref="DataNotificationTemplateVO"/> SDP
/// (não herda SCH: parâmetros de interface são invariantes).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Email.INotificationPlatformService",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Espelho de contrato; VO usa namespace SDP Domain.VO.")]
public interface INotificationPlatformService
{
    Task SendAsync(DataNotificationTemplateVO template, Dictionary<string, string> tokens);
}
