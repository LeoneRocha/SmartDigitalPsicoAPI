using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Contratcs;
using SmartDigitalPsico.Domain.VO.Patient.PatientRecord;
using SmartDigitalPsico.Service.Generic;
using SmartDigitalPsico.Service.SystemDomains;

namespace SmartDigitalPsico.Service.Principals
{
    public class PatientRecordService : EntityBaseService<PatientRecord, AddPatientRecordVO, UpdatePatientRecordVO, GetPatientRecordVO, IPatientRecordRepository>, IPatientRecordService

    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IPatientRecordRepository _entityRepository;

        public PatientRecordService(IMapper mapper
            , IPatientRecordRepository entityRepository, IConfiguration configuration, IUserRepository userRepository, IPatientRepository patientRepository
            , IValidator<PatientRecord> entityValidator
            , IApplicationLanguageRepository applicationLanguageRepository
            , ICacheService cacheService)
            : base(mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _mapper = mapper;
            _entityRepository = entityRepository;
            _userRepository = userRepository;
        }
        public override async Task<ServiceResponse<GetPatientRecordVO>> Create(AddPatientRecordVO item)
        {
            ServiceResponse<GetPatientRecordVO> response = new ServiceResponse<GetPatientRecordVO>();

            PatientRecord entityAdd = _mapper.Map<PatientRecord>(item);

            #region Relationship

            entityAdd.CreatedUserId = this.UserId;
            entityAdd.PatientId = item.PatientId;

            #endregion Relationship

            entityAdd.CreatedDate = DataHelper.GetDateTimeNow();
            entityAdd.ModifyDate = DataHelper.GetDateTimeNow();
            entityAdd.LastAccessDate = DataHelper.GetDateTimeNow();
            response = await base.Validate(entityAdd);

            if (response.Success)
            {
                PatientRecord entityResponse = await _entityRepository.Create(entityAdd);
                response.Data = _mapper.Map<GetPatientRecordVO>(entityResponse);
                response.Message = "Patient registred.";
            }
            return response;
        }
        public override async Task<ServiceResponse<GetPatientRecordVO>> Update(UpdatePatientRecordVO item)
        {
            ServiceResponse<GetPatientRecordVO> response = new ServiceResponse<GetPatientRecordVO>();

            PatientRecord entityUpdate = await _entityRepository.FindByID(item.Id);

            #region Set default fields for bussines

            entityUpdate.ModifyDate = DataHelper.GetDateTimeNow();
            entityUpdate.LastAccessDate = DataHelper.GetDateTimeNow();

            #endregion Set default fields for bussines

            #region User Action

            entityUpdate.ModifyUserId = this.UserId;

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
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
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
            response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsFound", base._applicationLanguageRepository, base._cacheService);

            return response;
        }
        public async override Task<ServiceResponse<List<GetPatientRecordVO>>> FindAll()
        {
            var result = new ServiceResponse<List<GetPatientRecordVO>>();
            result.Success = false;
            result.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsNotFound", base._applicationLanguageRepository, base._cacheService);

            return result;
        }
        public async override Task<ServiceResponse<GetPatientRecordVO>> FindByID(long id)
        {
            return await base.FindByID(id);
        }
    }
}