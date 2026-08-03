using System.ComponentModel;

namespace SmartDigitalPsico.Domain.Enuns
{
    /// <summary>
    /// Enumeração responsável por ETypeApiCredential.
    /// Responsabilidade: valores enumerados do domínio.
    /// Relação: usado em entidades, DTOs e regras de negócio.
    /// </summary>
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
