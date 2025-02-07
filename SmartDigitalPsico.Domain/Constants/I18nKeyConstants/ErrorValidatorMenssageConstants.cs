namespace SmartDigitalPsico.Domain.Constants.I18nKeyConstants
{
    public static class ErrorValidatorMenssageConstants
    {
        public const string AccreditationNull = "Accreditation cannot be empty.";
        public const string AccreditationUnique = "Accreditation must be unique.";
        public const string AnnotationDateNull = "Annotation date cannot be empty.";
        public const string AnnotationNull = "Annotation cannot be empty.";
        public const string CPFNull = "CPF cannot be empty.";
        public const string CreatedUserIdNull = "The user creating must be provided.";
        public const string DateOfBirthInvalid = "Date of birth is invalid";
        public const string DescriptionNull = "Description cannot be empty";
        public const string EmailInvalid = "Email is invalid.";
        public const string EmailNull = "Email cannot be empty";
        public const string EmailUnique = "Email must be unique.";
        public const string LanguageMaximumLength = "Language cannot exceed {MaxLength}";
        public const string LanguageNull = "Language cannot be empty";
        public const string LoginNull = "Login cannot be empty.";
        public const string LoginUnique = "Login must be unique.";
        public const string NameNull = "Name cannot be empty";
        public const string RGNull = "RG cannot be empty.";
        public const string ErrorValidator_User_Not_Permission = "You do not have the necessary permissions to perform this action.";


        #region MEDICAL 
        public const string MedicalChanged = "The provided doctor must be the logged-in one. Doctors cannot create files for another doctor.";
        public const string MedicalCreatedInvalid = "The provided doctor must be the logged-in one. Doctors cannot create files for another doctor.";
        public const string MedicalIdNotFound = "The provided doctor does not exist.";
        public const string MedicalIdNull = "Doctor must be provided.";
        public const string MedicalModifyInvalid = "The provided doctor must be the logged-in one. Doctors cannot modify files for another doctor.";
        #endregion MEDICAL

        #region Patient  
        public const string PatientChanged = "The patient cannot be changed.";
        public const string PatientMedicalCreated = "Patient information cannot be added by another doctor or user.";
        public const string PatientMedicalModify = "Patient information cannot be modified by another doctor or user.";
        public const string PatientNotFound = "The provided patient does not exist.";
        public const string PatientNull = "Patient must be provided.";
        #endregion Patient
    }
}