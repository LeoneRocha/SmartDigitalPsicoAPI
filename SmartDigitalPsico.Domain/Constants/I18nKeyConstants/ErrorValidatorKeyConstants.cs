namespace SmartDigitalPsico.Domain.Constants.I18nKeyConstants
{
    public static class ErrorValidatorKeyConstants
    { 
        public const string AccreditationNull = "ErrorValidator_Accreditation_Null";
        public const string AccreditationUnique = "ErrorValidator_Accreditation_Unique";
        public const string AnnotationDateNull = "ErrorValidator_AnnotationDate_Null";
        public const string AnnotationNull = "ErrorValidator_Annotation_Null";
        public const string CPFNull = "ErrorValidator_CPF_Null";
        public const string CreatedUserIdNull = "ErrorValidator_CreatedUserId_Null";
        public const string DateOfBirthInvalid = "ErrorValidator_DateOfBirth_Invalid";
        public const string DescriptionNull = "ErrorValidator_Description_Null";
        public const string EmailInvalid = "ErrorValidator_Email_Invalid";
        public const string EmailNull = "ErrorValidator_Email_Null";
        public const string EmailUnique = "ErrorValidator_Email_Unique";
        public const string LanguageMaximumLength = "ErrorValidator_Language_MaximumLength";
        public const string LanguageNull = "ErrorValidator_Language_Null";
        public const string LoginNull = "ErrorValidator_Login_Null";
        public const string LoginUnique = "ErrorValidator_Login_Unique";
        public const string NameNull = "ErrorValidator_Name_Null";
        public const string RGNull = "ErrorValidator_RG_Null";
        public const string ErrorValidator_User_Not_Permission = "ErrorValidator_User_Not_Permission";

        #region Patient
        public const string PatientChanged = "ErrorValidator_Patient_Changed";
        public const string PatientMedicalCreated = "ErrorValidator_Patient_Medical_Created";
        public const string PatientMedicalModify = "ErrorValidator_Patient_Medical_Modify";
        public const string PatientNotFound = "ErrorValidator_Patient_NotFound";
        public const string PatientNull = "ErrorValidator_Patient_Null";

        #endregion Patient

        #region MEDICAL 

        public const string MedicalChanged = "ErrorValidator_Medical_Changed";
        public const string MedicalCreatedInvalid = "ErrorValidator_MedicalCreated_Invalid";
        public const string MedicalIdNotFound = "ErrorValidator_MedicalId_NotFound";
        public const string MedicalIdNull = "ErrorValidator_MedicalId_Null";
        public const string MedicalModifyInvalid = "ErrorValidator_MedicalModify_Invalid";

        #endregion MEDICAL
    }

}