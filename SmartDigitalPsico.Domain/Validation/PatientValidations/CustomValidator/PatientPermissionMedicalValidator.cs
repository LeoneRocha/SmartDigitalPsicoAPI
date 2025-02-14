using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations.CustomValidator
{
    public static class PatientPermissionMedicalValidator
    {
        public static ErrorResponse ValidatePermissionMedical(long medicalId, User userAction)
        {
            if (userAction == null)
            {
                var error = new ErrorResponse()
                {
                    Message = "UserRequired_Key|Permission denied! User must be provided.",
                    Name = ValidatorConstants.Validate_Permission_Medical
                };
                return error;
            }
            else if (userAction.MedicalId != medicalId && !userAction.Admin)
            {
                var error = new ErrorResponse()
                {
                    Message = "MedicalUserMismatch_Key|Permission denied! The logged-in doctor must be the same as the one provided.",
                    Name = ValidatorConstants.Validate_Permission_Medical
                };

                return error;
            }
            return new ErrorResponse();
        }

        public static ErrorResponse ValidatePermissionAdmin(User userAction)
        {
            if (userAction == null)
            {
                var error = new ErrorResponse()
                {
                    ErrorCode = 401.ToString(),
                    Message = "UserRequired_Key|Permission denied! User must be provided.",
                    Name = ValidatorConstants.Validate_Permission_Medical
                };
                return error;
            }
            else if (!userAction.Admin)
            {
                var error = new ErrorResponse()
                {
                    ErrorCode = 401.ToString(),
                    Message = "AdminAccessOnly_Key|Permission denied! Only administrators can access.",
                    Name = ValidatorConstants.Validate_Permission_Medical
                };

                return error;
            }
            return new ErrorResponse();
        }
    }
}
