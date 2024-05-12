using AutoMapper;
using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Contratcs;
using SmartDigitalPsico.Domain.VO.Patient.PatientAdditionalInformation;
using SmartDigitalPsico.Service.Generic;
using SmartDigitalPsico.Service.SystemDomains;

namespace SmartDigitalPsico.Service.Principals
{
    public class PatientAdditionalInformationService : EntityBaseService<PatientAdditionalInformation, AddPatientAdditionalInformationVO, UpdatePatientAdditionalInformationVO, GetPatientAdditionalInformationVO
        , IPatientAdditionalInformationRepository>, IPatientAdditionalInformationService

    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IPatientAdditionalInformationRepository _entityRepository;

        public PatientAdditionalInformationService(IMapper mapper, IPatientAdditionalInformationRepository entityRepository, IUserRepository userRepository, IValidator<PatientAdditionalInformation> entityValidator, IApplicationLanguageRepository applicationLanguageRepository, ICacheService cacheService)
            : base(mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _mapper = mapper;
            _entityRepository = entityRepository;
            _userRepository = userRepository;
        }
        public async override Task<ServiceResponse<List<GetPatientAdditionalInformationVO>>> FindAll()
        {
            var result = new ServiceResponse<List<GetPatientAdditionalInformationVO>>();
            result.Success = false;
            result.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsNotFound", base._applicationLanguageRepository, base._cacheService);

            return result;
        }

        public override async Task<ServiceResponse<GetPatientAdditionalInformationVO>> Create(AddPatientAdditionalInformationVO item)
        {
            ServiceResponse<GetPatientAdditionalInformationVO> response = new ServiceResponse<GetPatientAdditionalInformationVO>();

            PatientAdditionalInformation entityAdd = _mapper.Map<PatientAdditionalInformation>(item);

            #region Relationship

            entityAdd.CreatedUserId = this.UserId;
            entityAdd.PatientId = item.PatientId;

            #endregion

            entityAdd.CreatedDate = DataHelper.GetDateTimeNow();
            entityAdd.ModifyDate = DataHelper.GetDateTimeNow();
            entityAdd.LastAccessDate = DataHelper.GetDateTimeNow();

            response = await base.Validate(entityAdd);

            if (response.Success)
            {
                PatientAdditionalInformation entityResponse = await _entityRepository.Create(entityAdd);

                response.Data = _mapper.Map<GetPatientAdditionalInformationVO>(entityResponse);
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                   ("RegisterCreated", base._applicationLanguageRepository, base._cacheService);
            }


            return response;
        }

        public override async Task<ServiceResponse<GetPatientAdditionalInformationVO>> Update(UpdatePatientAdditionalInformationVO item)
        {
            ServiceResponse<GetPatientAdditionalInformationVO> response = new ServiceResponse<GetPatientAdditionalInformationVO>();

            PatientAdditionalInformation entityUpdate = await _entityRepository.FindByID(item.Id);

            #region Relationship 
            entityUpdate.ModifyUserId = this.UserId;

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
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                   ("RegisterUpdated", base._applicationLanguageRepository, base._cacheService);
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
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("ErrorValidator_User_Not_Permission", base._applicationLanguageRepository, base._cacheService);
                return response;
            }

            if (listResult == null || listResult.Count == 0)
            {
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsNotFound", base._applicationLanguageRepository, base._cacheService);
                return response;
            }
            response.Data = listResult.Select(c => _mapper.Map<GetPatientAdditionalInformationVO>(c)).ToList();
            response.Success = true;
            response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsFound", base._applicationLanguageRepository, base._cacheService);
            return response;
        }
        public async override Task<ServiceResponse<GetPatientAdditionalInformationVO>> FindByID(long id)
        {
            return await base.FindByID(id);
        }
    }
}