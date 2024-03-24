using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Contratcs;
using SmartDigitalPsico.Domain.VO.Patient.PatientRecord;
using SmartDigitalPsico.Service.Generic;
using SmartDigitalPsico.Service.SystemDomains;

namespace SmartDigitalPsico.Service.Principals
{
    public class PatientRecordService : EntityBaseSimpleService<PatientRecord, AddPatientRecordVO, UpdatePatientRecordVO, GetPatientRecordVO, IPatientRecordRepository>, IPatientRecordService

    {
        private readonly IMapper _mapper;
        IConfiguration _configuration;
        private readonly IUserRepository _userRepository;
        private readonly IPatientRecordRepository _entityRepository;
        private readonly IPatientRepository _patientRepository;

        public PatientRecordService(IMapper mapper, IPatientRecordRepository entityRepository, IConfiguration configuration, IUserRepository userRepository, IPatientRepository patientRepository
            , IValidator<PatientRecord> entityValidator
            , IApplicationLanguageRepository applicationLanguageRepository
            , ICacheService cacheService)
            : base(mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _mapper = mapper;
            _configuration = configuration;
            _entityRepository = entityRepository;
            _userRepository = userRepository;
            _patientRepository = patientRepository;
        }
        public override async Task<ServiceResponse<GetPatientRecordVO>> Create(AddPatientRecordVO item)
        {
            ServiceResponse<GetPatientRecordVO> response = new ServiceResponse<GetPatientRecordVO>();
            try
            {
                PatientRecord entityAdd = _mapper.Map<PatientRecord>(item);

                #region Relationship

                User userAction = await _userRepository.FindByID(this.UserId);
                entityAdd.CreatedUser = userAction;

                Patient patientAdd = await _patientRepository.FindByID(item.PatientId);
                entityAdd.Patient = patientAdd;

                #endregion Relationship

                entityAdd.CreatedDate = DateTime.Now;
                entityAdd.ModifyDate = DateTime.Now;
                entityAdd.LastAccessDate = DateTime.Now;
                response = await base.Validate(entityAdd);

                if (response.Success)
                {
                    PatientRecord entityResponse = await _entityRepository.Create(entityAdd);
                    response.Data = _mapper.Map<GetPatientRecordVO>(entityResponse);
                    response.Message = "Patient registred.";
                }
            }
            catch (Exception)
            {

                throw;
            }
            return response;
        }
        public override async Task<ServiceResponse<GetPatientRecordVO>> Update(UpdatePatientRecordVO item)
        {
            ServiceResponse<GetPatientRecordVO> response = new ServiceResponse<GetPatientRecordVO>();
            try
            {
                PatientRecord entityUpdate = await _entityRepository.FindByID(item.Id);

                #region Set default fields for bussines

                entityUpdate.ModifyDate = DateTime.Now;
                entityUpdate.LastAccessDate = DateTime.Now;

                #endregion Set default fields for bussines

                #region User Action

                User userAction = await _userRepository.FindByID(this.UserId);
                entityUpdate.ModifyUser = userAction;

                #endregion User Action

                #region Relationship 

                #endregion Relationship

                #region Columns
                entityUpdate.Enable = item.Enable;
                entityUpdate.Annotation = item.Annotation;
                entityUpdate.Description = item.Description;
                entityUpdate.AnnotationDate = item.AnnotationDate;
                #endregion Columns

                response = await base.Validate(entityUpdate);
                if (response.Success)
                {
                    PatientRecord entityResponse = await _entityRepository.Update(entityUpdate);
                    response.Data = _mapper.Map<GetPatientRecordVO>(entityResponse);
                    response.Message = "Patient Updated.";
                }
            }
            catch (Exception ex)
            {
                //TODO: GENARATE LOGS
                throw ex;
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetPatientRecordVO>>> FindAllByPatient(long patientId)
        {
            ServiceResponse<List<GetPatientRecordVO>> response = new ServiceResponse<List<GetPatientRecordVO>>();

            var listResult = await _entityRepository.FindAllByPatient(patientId);

            var recordsList = new RecordsList<PatientRecord>
            {
                UserIdLogged = base.UserId,
                Records = listResult

            };
            var validator = new PatientRecordSelectListValidator(_userRepository);
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
            response.Data = listResult.Select(c => _mapper.Map<GetPatientRecordVO>(c)).ToList();
            response.Success = true;
            response.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                       ("RegisterIsFound", base._applicationLanguageRepository, base._cacheService);

            return response;
        }
        public async override Task<ServiceResponse<List<GetPatientRecordVO>>> FindAll()
        {
            var result = new ServiceResponse<List<GetPatientRecordVO>>();
            result.Success = false;
            result.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                       ("RegisterIsNotFound", base._applicationLanguageRepository, base._cacheService);

            return result;
        } 
        public async override Task<ServiceResponse<GetPatientRecordVO>> FindByID(long id)
        {
            return await base.FindByID(id);
        }
    }
}