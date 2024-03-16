﻿using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Domain.Validation.PatientValidations
{
    public class PatientFileValidator : AbstractValidator<PatientFile>
    {
        private IPatientFileRepository _entityRepository;
        private IPatientRepository _patientRepository;
        private IMedicalRepository _medicalRepository;
        private IUserRepository _userRepository;

        public PatientFileValidator(IPatientFileRepository entityRepository,
            IPatientRepository patientRepository, IMedicalRepository medicalRepository, IUserRepository userRepository)
        {
            _entityRepository = entityRepository;
            _patientRepository = patientRepository;
            _medicalRepository = medicalRepository;
            _userRepository = userRepository;

            #region Columns
            RuleFor(entity => entity.Description)
                .MaximumLength(255)
                .WithMessage("O Description não pode ultrapassar {MaxLength} carateres.");
             
            RuleFor(entity => entity.FilePath)
                .MaximumLength(2083)
                .WithMessage("O FilePath não pode ultrapassar {MaxLength} carateres.");

            RuleFor(entity => entity.FileExtension)
             .MaximumLength(3)
             .WithMessage("O FileExtension não pode ultrapassar {MaxLength} carateres.");
             
            RuleFor(entity => entity.FileContentType)
             .MaximumLength(100)
             .WithMessage("O FileContentType não pode ultrapassar {MaxLength} carateres.");

            #endregion Columns

            #region Relationship

            RuleFor(entity => entity.CreatedUser)
              .NotNull() 
              .WithMessage("ErrorValidator_CreatedUser_Null");

            RuleFor(entity => entity.PatientId)
              .NotNull() 
              .WithMessage("ErrorValidator_Patient_Null")
              .MustAsync(async (entity, value, c) => await PatientIdFound(entity, value)) 
              .WithMessage("ErrorValidator_Patient_NotFound")
              .MustAsync(async (entity, value, c) => await PatientIdChanged(entity, value)) 
              .WithMessage("ErrorValidator_Patient_Changed")
              .MustAsync(async (entity, value, c) => await MedicalCreated(entity, value)) 
              .WithMessage("ErrorValidator_Patient_Medical_Created")
              .MustAsync(async (entity, value, c) => await MedicalModify(entity, value)) 
              .WithMessage("ErrorValidator_Patient_Medical_Modify");

            #endregion Relationship  
        }

        private async Task<bool> PatientIdFound(PatientFile entity, long value)
        {
            var entityFind = await _patientRepository.FindByID(entity.PatientId);
            if (entityFind == null)
            {
                return false;
            }
            return true;
        }
        private async Task<bool> PatientIdChanged(PatientFile entity, long value)
        {
            var entityBefore = await _entityRepository.FindByID(entity.Id);
            if (entityBefore != null)
            {
                if (entityBefore.PatientId != entity.PatientId)
                {
                    return false;
                }
            }
            return true;
        }
        private async Task<bool> MedicalCreated(PatientFile entity, long value)
        {
            long idUser = entity.CreatedUserId.GetValueOrDefault();

            var patient = await _patientRepository.FindByID(entity.PatientId);
            if (patient != null)
            {
                if (patient.Medical.UserId != idUser)
                {
                    return false;
                }
            }
            return true;
        }
        private async Task<bool> MedicalModify(PatientFile entity, long value)
        {
            long idUser = entity.ModifyUserId.GetValueOrDefault();

            var patient = await _patientRepository.FindByID(entity.PatientId);
            if (patient != null)
            {
                if (patient.Medical.UserId != idUser)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
