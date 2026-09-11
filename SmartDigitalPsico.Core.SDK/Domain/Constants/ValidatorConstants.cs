using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Service.Validation;

namespace SmartDigitalPsico.Core.SDK.Domain.Constants;

/// <summary>
/// Casca ValidatorConstants — espelho SCH + chave médica SDP local.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.Validation.ValidatorConstants",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper espelhando ValidatorConstants do SCH; Validate_Permission_Medical retido na casca.")]
public static class ValidatorConstants
{
    /// <summary>Chave SDP clínica (não existe como mesmo literal no SCH).</summary>
    public const string Validate_Permission_Medical = "Validate_Permission_Medical";

    public const string GenericErroMessageKey = Sch.ValidatorConstants.GenericErroMessageKey;
    public const string Generic_Erro_Message = Sch.ValidatorConstants.Generic_Erro_Message;

    public const string ValidateErroMessageKey = Sch.ValidatorConstants.ValidateErroMessageKey;
    public const string ValidateErroMessage_Message = Sch.ValidatorConstants.ValidateErroMessage_Message;
    public const string ValidateSuccessMessageKey = Sch.ValidatorConstants.ValidateSuccessMessageKey;
    public const string ValidateSuccessMessage_Message = Sch.ValidatorConstants.ValidateSuccessMessage_Message;
    public const string Validade_UserNotFound = Sch.ValidatorConstants.Validade_UserNotFound;
}
