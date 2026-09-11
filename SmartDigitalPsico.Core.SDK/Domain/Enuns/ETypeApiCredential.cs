using System.ComponentModel;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SchEnums = SmartCoreHub.Core.SDK.Domain.Enums;

namespace SmartDigitalPsico.Core.SDK.Domain.Enuns;

/// <summary>
/// Casca enum espelho de tipo de credencial de API.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Enums.ETypeApiCredential",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Enum espelho; valores int idênticos ao SCH.")]
public enum ETypeApiCredential
{
    [Description("JSON Web Token - Bearer")]
    Jwt = (int)SchEnums.ETypeApiCredential.Jwt,

    [Description("Azure Active Directory")]
    AzureAD = (int)SchEnums.ETypeApiCredential.AzureAD,

    [Description("Google Cloud Identity")]
    GoogleCloudIdentity = (int)SchEnums.ETypeApiCredential.GoogleCloudIdentity,

    [Description("AWS IAM Identity Center")]
    AWSIdentity = (int)SchEnums.ETypeApiCredential.AWSIdentity,
}
