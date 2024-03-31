using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Patient;
using SmartDigitalPsico.Service.Generic;
using SmartDigitalPsico.Service.SystemDomains;
using SmartDigitalPsico.Domain.Validation.Contratcs;
using SmartDigitalPsico.Domain.Validation.PatientValidations.CustomValidator;
using SmartDigitalPsico.Domain.Helpers;

namespace SmartDigitalPsico.Service.Principals
{
    public class PatientService : EntityBaseService<Patient, AddPatientVO, UpdatePatientVO, GetPatientVO, IPatientRepository>, IPatientService

    {
        private readonly IMapper _mapper;
        IConfiguration _configuration;
        private readonly IUserRepository _userRepository;
        private readonly IPatientRepository _entityRepository;
        private readonly IMedicalRepository _medicalRepository;
        private readonly IValidator<Patient> _entityValidator;

        public PatientService(IMapper mapper, IPatientRepository entityRepository, IConfiguration configuration, IUserRepository userRepository, IMedicalRepository medicalRepository
            , IValidator<Patient> entityValidator
            , IApplicationLanguageRepository applicationLanguageRepository, ICacheService cacheService)
            : base(mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _mapper = mapper;
            _configuration = configuration;
            _entityRepository = entityRepository;
            _userRepository = userRepository;
            _medicalRepository = medicalRepository;
            _entityValidator = entityValidator;
        }
        public override async Task<ServiceResponse<GetPatientVO>> Create(AddPatientVO item)
        {
            ServiceResponse<GetPatientVO> response = new ServiceResponse<GetPatientVO>();
            try
            {
                Patient entityAdd = _mapper.Map<Patient>(item);

                #region Set default fields for bussines

                entityAdd.CreatedDate = CultureDateTimeHelper.GetDateTimeNow();
                entityAdd.ModifyDate = CultureDateTimeHelper.GetDateTimeNow();
                entityAdd.LastAccessDate = CultureDateTimeHelper.GetDateTimeNow();

                #endregion Set default fields for bussines

                #region User Action

                entityAdd.CreatedUserId = this.UserId;

                #endregion User Action

                response = await base.Validate(entityAdd);
                if (response.Success)
                {
                    #region Relationship 

                    entityAdd.MedicalId = item.MedicalId;
                    entityAdd.GenderId = item.GenderId;
                    #endregion Relationship

                    Patient entityResponse = await _entityRepository.Create(entityAdd);
                    response.Data = _mapper.Map<GetPatientVO>(entityResponse);
                    response.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                       ("RegisterCreated", base._applicationLanguageRepository, base._cacheService);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return response;
        }

        public override async Task<ServiceResponse<GetPatientVO>> Update(UpdatePatientVO item)
        {
            ServiceResponse<GetPatientVO> response = new ServiceResponse<GetPatientVO>();
            try
            {
                Patient? entityUpdate = await _entityRepository.FindByID(item.Id);
                if (entityUpdate != null)
                {

                    #region Set default fields for bussines

                    entityUpdate.ModifyDate = CultureDateTimeHelper.GetDateTimeNow();
                    entityUpdate.LastAccessDate = CultureDateTimeHelper.GetDateTimeNow();

                    #endregion Set default fields for bussines

                    #region User Action
                     
                    entityUpdate.ModifyUserId = this.UserId;

                    #endregion User Action

                    #region Relationship

                    entityUpdate.GenderId = item.GenderId;

                    #endregion Relationship

                    #region Columns
                    entityUpdate.Enable = item.Enable;
                    entityUpdate.Name = item.Name;
                    entityUpdate.Email = item.Email;
                    entityUpdate.Cpf = item.Cpf;
                    entityUpdate.Rg = item.Rg;
                    entityUpdate.Education = item.Education;
                    entityUpdate.DateOfBirth = item.DateOfBirth;
                    entityUpdate.PhoneNumber = item.PhoneNumber;
                    entityUpdate.Profession = item.Profession;

                    entityUpdate.EmergencyContactName = item.EmergencyContactName;
                    entityUpdate.EmergencyContactPhoneNumber = item.EmergencyContactPhoneNumber;

                    entityUpdate.AddressCep = item.AddressCep;
                    entityUpdate.AddressCity = item.AddressCity;
                    entityUpdate.AddressStreet = item.AddressStreet;
                    entityUpdate.AddressState = item.AddressState;
                    entityUpdate.AddressNeighborhood = item.AddressNeighborhood;

                    #endregion Columns

                    response = await base.Validate(entityUpdate);
                    if (response.Success)
                    {
                        Patient entityResponse = await _entityRepository.Update(entityUpdate);
                        response.Data = _mapper.Map<GetPatientVO>(entityResponse);
                        response.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                           ("RegisterUpdated", base._applicationLanguageRepository, base._cacheService);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return response;
        }

        public async Task<ServiceResponse<GetPatientVO>> FindByPatient(GetPatientVO info)
        {
            ServiceResponse<GetPatientVO> response = new ServiceResponse<GetPatientVO>();

            var patientFind = _mapper.Map<Patient>(info);

            var patientFinded = await _entityRepository.FindByPatient(patientFind);

            if (patientFinded == null)
            {
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                       ("RegisterIsNotFound", base._applicationLanguageRepository, base._cacheService);
                return response;
            }
            response.Data = _mapper.Map<GetPatientVO>(patientFinded);
            response.Success = true;
            response.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                       ("RegisterIsFound", base._applicationLanguageRepository, base._cacheService);
            return response;

        }
        public override async Task<ServiceResponse<List<GetPatientVO>>> FindAll()
        {
            await Task.Yield();
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<GetPatientVO>>> FindAll(long medicalId)
        {
            ServiceResponse<List<GetPatientVO>> response = new ServiceResponse<List<GetPatientVO>>();
            try
            {
                List<Patient> listResult = await _entityRepository.FindAllByMedicalId(medicalId);
                var recordsList = new RecordsList<Patient>
                {
                    UserIdLogged = base.UserId,
                    Records = listResult

                };
                var validator = new PatientSelectListValidator(_userRepository);
                var validationResult = await validator.ValidateAsync(recordsList);
                if (!validationResult.IsValid)
                {
                    response.Errors = validator.GetMapErros(validationResult.Errors);
                    response.Success = false;
                    response.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                           ("ErrorValidator_User_Not_Permission", base._applicationLanguageRepository, base._cacheService);
                    return response;
                }
                if (listResult == null || listResult.Count == 0)
                {
                    response.Success = false;
                    response.Message = "Patients not found.";
                    return response;
                }
                response.Data = listResult.Select(c => _mapper.Map<GetPatientVO>(c)).ToList();
                response.Success = true;
                response.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                       ("RegisterIsFound", base._applicationLanguageRepository, base._cacheService);
            }
            catch (Exception)
            {
                throw;
            }
            return response;
        }

        private async Task<ServiceResponse<List<GetPatientVO>>> validAccessToList(long medicalId)
        {
            ServiceResponse<List<GetPatientVO>> response = new ServiceResponse<List<GetPatientVO>>();
            response.Success = true;

            User userAction = await _userRepository.FindByID(this.UserId);
            var validateResult = PatientPermissionMedicalValidator.ValidatePermissionMedical(medicalId, userAction);
            bool invalidAccess = validateResult != null;
            if (invalidAccess)
            {
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                       ("RegisterIsFound", base._applicationLanguageRepository, base._cacheService);

                response.Errors = new List<ErrorResponse>();
                response.Errors.Add(validateResult);
                return response;
            }
            return response;
        }
    }
}