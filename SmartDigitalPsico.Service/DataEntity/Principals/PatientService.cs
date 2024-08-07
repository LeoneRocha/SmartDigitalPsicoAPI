using AutoMapper;
using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator;
using SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator;
using SmartDigitalPsico.Domain.VO.Patient;
using SmartDigitalPsico.Service.DataEntity.Generic;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    public class PatientService : EntityBaseService<Patient, AddPatientVO, UpdatePatientVO, GetPatientVO, IPatientRepository>, IPatientService

    {
        private readonly IUserRepository _userRepository;
        public PatientService(IMapper mapper
            , Serilog.ILogger logger
            , IResiliencePolicyConfig policyConfig
            , IPatientRepository entityRepository
            , IUserRepository userRepository
            , IValidator<Patient> entityValidator
            , IApplicationLanguageRepository applicationLanguageRepository
            , ICacheService cacheService)
            : base(mapper, logger, policyConfig, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _userRepository = userRepository;
        }
        public override async Task<ServiceResponse<GetPatientVO>> Create(AddPatientVO item)
        {
            Patient entityAdd = _mapper.Map<Patient>(item);

            #region Set default fields for bussines

            entityAdd.CreatedDate = DataHelper.GetDateTimeNow();
            entityAdd.ModifyDate = DataHelper.GetDateTimeNow();
            entityAdd.LastAccessDate = DataHelper.GetDateTimeNow();

            #endregion Set default fields for bussines

            #region User Action

            entityAdd.CreatedUserId = UserId;

            #endregion User Action

            ServiceResponse<GetPatientVO> response = await base.Validate(entityAdd);
            if (response.Success)
            {
                #region Relationship 

                entityAdd.MedicalId = item.MedicalId;
                entityAdd.GenderId = item.GenderId;
                #endregion Relationship

                Patient entityResponse = await _entityRepository.Create(entityAdd);
                response.Data = _mapper.Map<GetPatientVO>(entityResponse);
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                   ("RegisterCreated", _applicationLanguageRepository, _cacheService);
            }
            return response;
        }

        public override async Task<ServiceResponse<GetPatientVO>> Update(UpdatePatientVO item)
        {
            ServiceResponse<GetPatientVO> response = new ServiceResponse<GetPatientVO>();
            Patient? entityUpdate = await _entityRepository.FindByID(item.Id);
            if (entityUpdate != null)
            {
                #region Set default fields for bussines

                entityUpdate.ModifyDate = DataHelper.GetDateTimeNow();
                entityUpdate.LastAccessDate = DataHelper.GetDateTimeNow();

                #endregion Set default fields for bussines

                #region User Action

                entityUpdate.ModifyUserId = UserId;

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
                    response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterUpdated", _applicationLanguageRepository, _cacheService);
                }
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
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsNotFound", _applicationLanguageRepository, _cacheService);
                return response;
            }
            response.Data = _mapper.Map<GetPatientVO>(patientFinded);
            response.Success = true;
            response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsFound", _applicationLanguageRepository, _cacheService);
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

            List<Patient> listResult = await _entityRepository.FindAllByMedicalId(medicalId);
            var recordsList = new RecordsList<Patient>
            {
                UserIdLogged = UserId,
                Records = listResult

            };
            var validator = new PatientSelectListValidator(_userRepository);
            var validationResult = await validator.ValidateAsync(recordsList);
            if (!validationResult.IsValid)
            {
                response.Errors = validator.GetMapErros(validationResult.Errors);
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("ErrorValidator_User_Not_Permission", _applicationLanguageRepository, _cacheService);
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
            response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                   ("RegisterIsFound", _applicationLanguageRepository, _cacheService);

            return response;
        }
        public override async Task<ServiceResponse<GetPatientVO>> FindByID(long id)
        {
            ServiceResponse<GetPatientVO> response = new ServiceResponse<GetPatientVO>();
            try
            {
                Patient entityResponse = await _entityRepository.FindByID(id);

                var recordData = new Record<Patient>
                {
                    UserIdLogged = UserId,
                    RecordEntity = entityResponse
                };

                var validator = new PatientSelectOneValidator(_userRepository);
                var validationResult = await validator.ValidateAsync(recordData);
                if (!validationResult.IsValid)
                {
                    response.Errors = validator.GetMapErros(validationResult.Errors);
                    response.Success = false;
                    response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                           ("ErrorValidator_User_Not_Permission", _applicationLanguageRepository, _cacheService);
                    return response;
                }
                response.Data = _mapper.Map<GetPatientVO>(entityResponse);
                response.Success = true;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>("RegisterFind", _applicationLanguageRepository, _cacheService);
            }
            catch (Exception)
            {
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>("RegisterIsNotFound", _applicationLanguageRepository, _cacheService);
            }
            return response;
        }


    }
}