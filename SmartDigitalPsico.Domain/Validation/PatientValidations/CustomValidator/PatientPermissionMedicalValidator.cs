using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations.CustomValidator
{
    public class PatientPermissionMedicalValidator
    {
        public static ErrorResponse ValidatePermissionMedical(long medicalId, User userAction)
        {
            if (userAction == null)
            {
                var error = new ErrorResponse()
                {
                    Message = "Permissão negada! Deve se informa usuario.",
                    Name = ValidatorConstants.NameResponseValidate_ValidatePermissionMedical
                };
                return error;
            }
            else if (userAction.MedicalId != medicalId && !userAction.Admin)
            {
                var error = new ErrorResponse()
                {
                    Message = "Permissão negada! Medico Informado deve ser o mesmo logado.",
                    Name = ValidatorConstants.NameResponseValidate_ValidatePermissionMedical
                };

                return error;
            }
            return null;
        }

        public static ErrorResponse ValidatePermissionAdmin(User userAction)
        {
            if (userAction == null)
            {
                var error = new ErrorResponse()
                {
                    Message = "Permissão negada! Deve se informa usuario.",
                    Name = ValidatorConstants.NameResponseValidate_ValidatePermissionMedical
                };
                return error;
            }
            else if (!userAction.Admin)
            {
                var error = new ErrorResponse()
                {
                    Message = "Permissão negada! Apenas administradores podem acessar.",
                    Name = ValidatorConstants.NameResponseValidate_ValidatePermissionMedical
                };

                return error;
            }
            return null;
        }
    }
}
