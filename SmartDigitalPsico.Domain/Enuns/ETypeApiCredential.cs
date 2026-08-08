using System.ComponentModel;

namespace SmartDigitalPsico.Domain.Enuns
{
    /// <summary>
    /// Shim Obsolete — use SmartDigitalPsico.Core.SDK.Domain.Enuns.ETypeApiCredential.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public enum ETypeApiCredential
    {
        [Description("JSON Web Token - Bearer")]
        Jwt = 0,

        [Description("Azure Active Directory")]
        AzureAD = 1,

        [Description("Google Cloud Identity")]
        GoogleCloudIdentity = 2,

        [Description("AWS IAM Identity Center")]
        AWSIdentity = 3,
    }
}
