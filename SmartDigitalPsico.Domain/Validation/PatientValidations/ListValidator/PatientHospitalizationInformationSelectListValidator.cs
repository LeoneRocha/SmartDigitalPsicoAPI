﻿using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator
{
    public class PatientHospitalizationInformationSelectListValidator : BasePatientSelectListValidator<PatientHospitalizationInformation>
    {

        public PatientHospitalizationInformationSelectListValidator(IUserRepository userRepository)
           : base(userRepository)
        { 
            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(HasPermissionAsync)
                .WithMessage("ErrorValidator_User_Not_Permission|User does not have permission.");
        }
    }
}
