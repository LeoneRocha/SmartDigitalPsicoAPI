using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Contratcs;
using SmartDigitalPsico.Domain.VO.Patient.PatientHospitalizationInformation;
using SmartDigitalPsico.Service.Generic;
using SmartDigitalPsico.Service.SystemDomains;

namespace SmartDigitalPsico.Service.Principals
{
    public class PatientHospitalizationInformationService : EntityBaseService<PatientHospitalizationInformation, AddPatientHospitalizationInformationVO, UpdatePatientHospitalizationInformationVO, GetPatientHospitalizationInformationVO, IPatientHospitalizationInformationRepository>, IPatientHospitalizationInformationService

    {
        private readonly IMapper _mapper;
        IConfiguration _configuration;
        private readonly IUserRepository _userRepository;
        private readonly IPatientHospitalizationInformationRepository _entityRepository;
        private readonly IPatientRepository _patientRepository;

        public PatientHospitalizationInformationService(IMapper mapper, IPatientHospitalizationInformationRepository entityRepository, IConfiguration configuration, IUserRepository userRepository, IPatientRepository patientRepository
            , IValidator<PatientHospitalizationInformation> entityValidator, IApplicationLanguageRepository applicationLanguageRepository
            , ICacheService cacheService)
            : base(mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _mapper = mapper;
            _configuration = configuration;
            _entityRepository = entityRepository;
            _userRepository = userRepository;
            _patientRepository = patientRepository;
        }

        public override async Task<ServiceResponse<GetPatientHospitalizationInformationVO>> Create(AddPatientHospitalizationInformationVO item)
        {
            ServiceResponse<GetPatientHospitalizationInformationVO> response = new ServiceResponse<GetPatientHospitalizationInformationVO>();

            try
            {
                PatientHospitalizationInformation entityAdd = _mapper.Map<PatientHospitalizationInformation>(item);

                #region Relationship

                User userAction = await _userRepository.FindByID(this.UserId);
                entityAdd.CreatedUser = userAction;

                Patient patientAdd = await _patientRepository.FindByID(item.PatientId);
                entityAdd.Patient = patientAdd;

                #endregion

                entityAdd.CreatedDate = DateTime.Now;
                entityAdd.ModifyDate = DateTime.Now;
                entityAdd.LastAccessDate = DateTime.Now;
                
                response = await base.Validate(entityAdd);

                if (response.Success)
                {
                    PatientHospitalizationInformation entityResponse = await _entityRepository.Create(entityAdd);

                    response.Data = _mapper.Map<GetPatientHospitalizationInformationVO>(entityResponse); 
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

        public override async Task<ServiceResponse<GetPatientHospitalizationInformationVO>> Update(UpdatePatientHospitalizationInformationVO item)
        {
            ServiceResponse<GetPatientHospitalizationInformationVO> response = new ServiceResponse<GetPatientHospitalizationInformationVO>();

            try
            {
                PatientHospitalizationInformation entityUpdate = await _entityRepository.FindByID(item.Id);
                  
                #region Relationship

                User userAction = await _userRepository.FindByID(this.UserId);
                entityUpdate.ModifyUser = userAction;  
                #endregion
                 
                entityUpdate.ModifyDate = DateTime.Now;
                entityUpdate.LastAccessDate = DateTime.Now;
                 
                #region Columns
                entityUpdate.Enable = item.Enable;                
                entityUpdate.CID = item.CID;
                entityUpdate.Description = item.Description;
                entityUpdate.StartDate = item.StartDate;
                entityUpdate.EndDate = item.EndDate;
                entityUpdate.Observation = item.Observation;
                #endregion Columns

                response = await base.Validate(entityUpdate);

                if (response.Success)
                {
                    PatientHospitalizationInformation entityResponse = await _entityRepository.Update(entityUpdate);

                    response.Data = _mapper.Map<GetPatientHospitalizationInformationVO>(entityResponse);
                    response.Message = "Patient Updated.";
                }
            }
            catch (Exception)
            { 
                throw;
            }

            return response;
        }
        public async Task<ServiceResponse<List<GetPatientHospitalizationInformationVO>>> FindAllByPatient(long patientId)
        {
            ServiceResponse<List<GetPatientHospitalizationInformationVO>> response = new ServiceResponse<List<GetPatientHospitalizationInformationVO>>();

            var listResult = await _entityRepository.FindAllByPatient(patientId);

            var recordsList = new RecordsList<PatientHospitalizationInformation>
            {
                UserIdLogged = base.UserId,
                Records = listResult

            };
            var validator = new PatientHospitalizationInformationSelectListValidator(_userRepository);
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
            response.Data = listResult.Select(c => _mapper.Map<GetPatientHospitalizationInformationVO>(c)).ToList();
            response.Success = true;
            response.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                       ("RegisterIsFound", base._applicationLanguageRepository, base._cacheService);
            return response;
        }

        public async override Task<ServiceResponse<List<GetPatientHospitalizationInformationVO>>> FindAll()
        {
            var result = new ServiceResponse<List<GetPatientHospitalizationInformationVO>>();
            result.Success = false;
            result.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                       ("RegisterIsNotFound", base._applicationLanguageRepository, base._cacheService);

            return result;
        } 
        public async override Task<ServiceResponse<GetPatientHospitalizationInformationVO>> FindByID(long id)
        {
            return await base.FindByID(id);
        }
    }
}