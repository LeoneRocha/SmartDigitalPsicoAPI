using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Constants.I18nKeyConstants;

namespace SmartDigitalPsico.Core.SDK.Domain.Constants.I18nKeyConstants;

/// <summary>
/// Casca ErrorValidatorMenssageConstants — tipografia Menssage preservada.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Constants.I18nKeyConstants.ErrorValidatorMenssageConstants",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper espelhando ErrorValidatorMenssageConstants do SCH.")]
public static class ErrorValidatorMenssageConstants
{
    public const string AccreditationNull = Sch.ErrorValidatorMenssageConstants.AccreditationNull;
    public const string AccreditationUnique = Sch.ErrorValidatorMenssageConstants.AccreditationUnique;
    public const string AnnotationDateNull = Sch.ErrorValidatorMenssageConstants.AnnotationDateNull;
    public const string AnnotationNull = Sch.ErrorValidatorMenssageConstants.AnnotationNull;
    public const string CPFNull = Sch.ErrorValidatorMenssageConstants.CPFNull;
    public const string CreatedUserIdNull = Sch.ErrorValidatorMenssageConstants.CreatedUserIdNull;
    public const string DateOfBirthInvalid = Sch.ErrorValidatorMenssageConstants.DateOfBirthInvalid;
    public const string DescriptionNull = Sch.ErrorValidatorMenssageConstants.DescriptionNull;
    public const string EmailInvalid = Sch.ErrorValidatorMenssageConstants.EmailInvalid;
    public const string EmailNull = Sch.ErrorValidatorMenssageConstants.EmailNull;
    public const string EmailUnique = Sch.ErrorValidatorMenssageConstants.EmailUnique;
    public const string LanguageMaximumLength = Sch.ErrorValidatorMenssageConstants.LanguageMaximumLength;
    public const string LanguageNull = Sch.ErrorValidatorMenssageConstants.LanguageNull;
    public const string LoginNull = Sch.ErrorValidatorMenssageConstants.LoginNull;
    public const string LoginUnique = Sch.ErrorValidatorMenssageConstants.LoginUnique;
    public const string NameNull = Sch.ErrorValidatorMenssageConstants.NameNull;
    public const string RGNull = Sch.ErrorValidatorMenssageConstants.RGNull;
    public const string ErrorValidator_User_Not_Permission = Sch.ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission;

    #region MEDICAL
    public const string MedicalChanged = Sch.ErrorValidatorMenssageConstants.MedicalChanged;
    public const string MedicalCreatedInvalid = Sch.ErrorValidatorMenssageConstants.MedicalCreatedInvalid;
    public const string MedicalIdNotFound = Sch.ErrorValidatorMenssageConstants.MedicalIdNotFound;
    public const string MedicalIdNull = Sch.ErrorValidatorMenssageConstants.MedicalIdNull;
    public const string MedicalModifyInvalid = Sch.ErrorValidatorMenssageConstants.MedicalModifyInvalid;
    #endregion MEDICAL

    #region Patient
    public const string PatientChanged = Sch.ErrorValidatorMenssageConstants.PatientChanged;
    public const string PatientMedicalCreated = Sch.ErrorValidatorMenssageConstants.PatientMedicalCreated;
    public const string PatientMedicalModify = Sch.ErrorValidatorMenssageConstants.PatientMedicalModify;
    public const string PatientNotFound = Sch.ErrorValidatorMenssageConstants.PatientNotFound;
    public const string PatientNull = Sch.ErrorValidatorMenssageConstants.PatientNull;
    #endregion Patient
}
