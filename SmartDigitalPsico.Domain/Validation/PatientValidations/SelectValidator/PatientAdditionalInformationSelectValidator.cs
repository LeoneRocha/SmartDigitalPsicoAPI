﻿using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.Contratcs
{
    public class PatientAdditionalInformationSelectValidator : RecordValidator<PatientAdditionalInformation>
    {

        public PatientAdditionalInformationSelectValidator(IUserRepository userRepository)
            : base(userRepository)
        {
            RuleFor(recordsList => recordsList.UserIdLogged)
                .MustAsync(base.HasPermissionAsync)
                .WithMessage("ErrorValidator_User_Not_Permission");  
        }
    }
}