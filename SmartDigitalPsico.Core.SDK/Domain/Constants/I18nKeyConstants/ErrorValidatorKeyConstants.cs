using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Constants.I18nKeyConstants;

namespace SmartDigitalPsico.Core.SDK.Domain.Constants.I18nKeyConstants;

/// <summary>
/// Casca ErrorValidatorKeyConstants — espelho de constantes SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Constants.I18nKeyConstants.ErrorValidatorKeyConstants",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper espelhando ErrorValidatorKeyConstants do SCH.")]
public static class ErrorValidatorKeyConstants
{
    public const string AccreditationNull = Sch.ErrorValidatorKeyConstants.AccreditationNull;
    public const string AccreditationUnique = Sch.ErrorValidatorKeyConstants.AccreditationUnique;
    public const string AnnotationDateNull = Sch.ErrorValidatorKeyConstants.AnnotationDateNull;
    public const string AnnotationNull = Sch.ErrorValidatorKeyConstants.AnnotationNull;
    public const string CPFNull = Sch.ErrorValidatorKeyConstants.CPFNull;
    public const string CreatedUserIdNull = Sch.ErrorValidatorKeyConstants.CreatedUserIdNull;
    public const string DateOfBirthInvalid = Sch.ErrorValidatorKeyConstants.DateOfBirthInvalid;
    public const string DescriptionNull = Sch.ErrorValidatorKeyConstants.DescriptionNull;
    public const string EmailInvalid = Sch.ErrorValidatorKeyConstants.EmailInvalid;
    public const string EmailNull = Sch.ErrorValidatorKeyConstants.EmailNull;
    public const string EmailUnique = Sch.ErrorValidatorKeyConstants.EmailUnique;
    public const string LanguageMaximumLength = Sch.ErrorValidatorKeyConstants.LanguageMaximumLength;
    public const string LanguageNull = Sch.ErrorValidatorKeyConstants.LanguageNull;
    public const string LoginNull = Sch.ErrorValidatorKeyConstants.LoginNull;
    public const string LoginUnique = Sch.ErrorValidatorKeyConstants.LoginUnique;
    public const string NameNull = Sch.ErrorValidatorKeyConstants.NameNull;
    public const string RGNull = Sch.ErrorValidatorKeyConstants.RGNull;
    public const string ErrorValidator_User_Not_Permission = Sch.ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission;

    #region Patient
    public const string PatientChanged = Sch.ErrorValidatorKeyConstants.PatientChanged;
    public const string PatientMedicalCreated = Sch.ErrorValidatorKeyConstants.PatientMedicalCreated;
    public const string PatientMedicalModify = Sch.ErrorValidatorKeyConstants.PatientMedicalModify;
    public const string PatientNotFound = Sch.ErrorValidatorKeyConstants.PatientNotFound;
    public const string PatientNull = Sch.ErrorValidatorKeyConstants.PatientNull;
    #endregion Patient

    #region MEDICAL
    public const string MedicalChanged = Sch.ErrorValidatorKeyConstants.MedicalChanged;
    public const string MedicalCreatedInvalid = Sch.ErrorValidatorKeyConstants.MedicalCreatedInvalid;
    public const string MedicalIdNotFound = Sch.ErrorValidatorKeyConstants.MedicalIdNotFound;
    public const string MedicalIdNull = Sch.ErrorValidatorKeyConstants.MedicalIdNull;
    public const string MedicalModifyInvalid = Sch.ErrorValidatorKeyConstants.MedicalModifyInvalid;
    #endregion MEDICAL
}
