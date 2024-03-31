using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Patient.PatientAdditionalInformation;
using SmartDigitalPsico.Service.Generic;
using SmartDigitalPsico.Service.SystemDomains;
using SmartDigitalPsico.Domain.Validation.Contratcs;
using SmartDigitalPsico.Domain.Helpers;

namespace SmartDigitalPsico.Service.Principals
{
    public class PatientAdditionalInformationService : EntityBaseService<PatientAdditionalInformation, AddPatientAdditionalInformationVO, UpdatePatientAdditionalInformationVO, GetPatientAdditionalInformationVO
        , IPatientAdditionalInformationRepository>, IPatientAdditionalInformationService

    {
        private readonly IMapper _mapper;
        IConfiguration _configuration;
        private readonly IUserRepository _userRepository;
        private readonly IPatientAdditionalInformationRepository _entityRepository;
        private readonly IPatientRepository _patientRepository;

        public PatientAdditionalInformationService(IMapper mapper, IPatientAdditionalInformationRepository entityRepository, IConfiguration configuration, IUserRepository userRepository, IPatientRepository patientRepository
             , IValidator<PatientAdditionalInformation> entityValidator, IApplicationLanguageRepository applicationLanguageRepository, ICacheService cacheService)
            : base(mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _mapper = mapper;
            _configuration = configuration;
            _entityRepository = entityRepository;
            _userRepository = userRepository;
            _patientRepository = patientRepository;
        }
        public async override Task<ServiceResponse<List<GetPatientAdditionalInformationVO>>> FindAll()
        {
            var result = new ServiceResponse<List<GetPatientAdditionalInformationVO>>();
            result.Success = false;
            result.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                       ("RegisterIsNotFound", base._applicationLanguageRepository, base._cacheService);

            return result;
        }

        public override async Task<ServiceResponse<GetPatientAdditionalInformationVO>> Create(AddPatientAdditionalInformationVO item)
        {
            ServiceResponse<GetPatientAdditionalInformationVO> response = new ServiceResponse<GetPatientAdditionalInformationVO>();
            try
            {
                PatientAdditionalInformation entityAdd = _mapper.Map<PatientAdditionalInformation>(item);

                #region Relationship

                User? userAction = await _userRepository.FindByID(this.UserId);
                if (userAction != null)
                {
                    entityAdd.CreatedUser = userAction;
                }

                Patient? patientAdd = await _patientRepository.FindByID(item.PatientId);
                if (patientAdd != null)
                {
                    entityAdd.Patient = patientAdd;
                }
                #endregion

                entityAdd.CreatedDate = DataHelper.GetDateTimeNow();
                entityAdd.ModifyDate = DataHelper.GetDateTimeNow();
                entityAdd.LastAccessDate = DataHelper.GetDateTimeNow();

                response = await base.Validate(entityAdd);

                if (response.Success)
                {
                    PatientAdditionalInformation entityResponse = await _entityRepository.Create(entityAdd);

                    response.Data = _mapper.Map<GetPatientAdditionalInformationVO>(entityResponse);
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

        public override async Task<ServiceResponse<GetPatientAdditionalInformationVO>> Update(UpdatePatientAdditionalInformationVO item)
        {
            ServiceResponse<GetPatientAdditionalInformationVO> response = new ServiceResponse<GetPatientAdditionalInformationVO>();
            try
            {
                PatientAdditionalInformation entityUpdate = await _entityRepository.FindByID(item.Id);

                #region Relationship

                User userAction = await _userRepository.FindByID(this.UserId);
                entityUpdate.ModifyUser = userAction;

                #endregion Relationship

                entityUpdate.ModifyDate = DataHelper.GetDateTimeNow();
                entityUpdate.LastAccessDate = DataHelper.GetDateTimeNow();

                #region Columns
                entityUpdate.Enable = item.Enable;
                entityUpdate.FollowUp_Neurological = item.FollowUp_Neurological;
                entityUpdate.FollowUp_Psychiatric = item.FollowUp_Psychiatric;
                #endregion Columns

                response = await base.Validate(entityUpdate);

                if (response.Success)
                {
                    PatientAdditionalInformation entityResponse = await _entityRepository.Update(entityUpdate);

                    response.Data = _mapper.Map<GetPatientAdditionalInformationVO>(entityResponse);
                    response.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                       ("RegisterUpdated", base._applicationLanguageRepository, base._cacheService);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return response;
        }

        public async Task<ServiceResponse<List<GetPatientAdditionalInformationVO>>> FindAllByPatient(long patientId)
        {
            ServiceResponse<List<GetPatientAdditionalInformationVO>> response = new ServiceResponse<List<GetPatientAdditionalInformationVO>>();

            var listResult = await _entityRepository.FindAllByPatient(patientId);

            var recordsList = new RecordsList<PatientAdditionalInformation>
            {
                UserIdLogged = base.UserId,
                Records = listResult

            };
            var validator = new PatientAdditionalInformationSelectListValidator(_userRepository);
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
                response.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                       ("RegisterIsNotFound", base._applicationLanguageRepository, base._cacheService);
                return response;
            }
            response.Data = listResult.Select(c => _mapper.Map<GetPatientAdditionalInformationVO>(c)).ToList();
            response.Success = true;
            response.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                       ("RegisterIsFound", base._applicationLanguageRepository, base._cacheService);
            return response;
        }
        public async override Task<ServiceResponse<GetPatientAdditionalInformationVO>> FindByID(long id)
        {
            return await base.FindByID(id);
        }
    }
}