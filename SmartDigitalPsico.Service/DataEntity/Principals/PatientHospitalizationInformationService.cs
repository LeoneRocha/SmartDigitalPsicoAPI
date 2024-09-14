using FluentValidation;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.PatientValidations.ListValidator;
using SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator;
using SmartDigitalPsico.Domain.VO.Patient.PatientHospitalizationInformation;
using SmartDigitalPsico.Service.DataEntity.Generic;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    public class PatientHospitalizationInformationService : EntityBaseService<PatientHospitalizationInformation, AddPatientHospitalizationInformationVO, UpdatePatientHospitalizationInformationVO, GetPatientHospitalizationInformationVO, IPatientHospitalizationInformationRepository>, IPatientHospitalizationInformationService

    {
        private readonly IUserRepository _userRepository;

        public PatientHospitalizationInformationService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IPatientHospitalizationInformationRepository entityRepository,
            IValidator<PatientHospitalizationInformation> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
            _userRepository = sharedRepositories.UserRepository;
        }

        public override async Task<ServiceResponse<GetPatientHospitalizationInformationVO>> Create(AddPatientHospitalizationInformationVO item)
        {

            PatientHospitalizationInformation entityAdd = _mapper.Map<PatientHospitalizationInformation>(item);

            #region Relationship

            entityAdd.CreatedUserId = UserId;
            entityAdd.PatientId = item.PatientId;

            #endregion

            entityAdd.CreatedDate = DataHelper.GetDateTimeNow();
            entityAdd.ModifyDate = DataHelper.GetDateTimeNow();
            entityAdd.LastAccessDate = DataHelper.GetDateTimeNow();

            ServiceResponse<GetPatientHospitalizationInformationVO> response = await base.Validate(entityAdd);

            if (response.Success)
            {
                PatientHospitalizationInformation entityResponse = await _entityRepository.Create(entityAdd);

                response.Data = _mapper.Map<GetPatientHospitalizationInformationVO>(entityResponse);
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                   ("RegisterCreated", _applicationLanguageRepository, _cacheService);
            }

            return response;
        }

        public override async Task<ServiceResponse<GetPatientHospitalizationInformationVO>> Update(UpdatePatientHospitalizationInformationVO item)
        {

            PatientHospitalizationInformation entityUpdate = await _entityRepository.FindByID(item.Id);

            #region Relationship                 
            entityUpdate.ModifyUserId = UserId;
            #endregion

            entityUpdate.ModifyDate = DataHelper.GetDateTimeNow();
            entityUpdate.LastAccessDate = DataHelper.GetDateTimeNow();

            #region Columns
            entityUpdate.Enable = item.Enable;
            entityUpdate.CID = item.CID;
            entityUpdate.Description = item.Description;
            entityUpdate.StartDate = item.StartDate;
            entityUpdate.EndDate = item.EndDate;
            entityUpdate.Observation = item.Observation;
            #endregion Columns

            ServiceResponse<GetPatientHospitalizationInformationVO> response = await base.Validate(entityUpdate);

            if (response.Success)
            {
                PatientHospitalizationInformation entityResponse = await _entityRepository.Update(entityUpdate);

                response.Data = _mapper.Map<GetPatientHospitalizationInformationVO>(entityResponse);
                response.Message = "Patient Updated.";
            }

            return response;
        }
        public async Task<ServiceResponse<List<GetPatientHospitalizationInformationVO>>> FindAllByPatient(long patientId)
        {
            ServiceResponse<List<GetPatientHospitalizationInformationVO>> response = new ServiceResponse<List<GetPatientHospitalizationInformationVO>>();

            var listResult = await _entityRepository.FindAllByPatient(patientId);

            var recordsList = new RecordsList<PatientHospitalizationInformation>
            {
                UserIdLogged = UserId,
                Records = listResult

            };
            var validator = new PatientHospitalizationInformationSelectListValidator(_userRepository);
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
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsNotFound", _applicationLanguageRepository, _cacheService);
                return response;
            }
            response.Data = listResult.Select(c => _mapper.Map<GetPatientHospitalizationInformationVO>(c)).ToList();
            response.Success = true;
            response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsFound", _applicationLanguageRepository, _cacheService);
            return response;
        }

        public async override Task<ServiceResponse<List<GetPatientHospitalizationInformationVO>>> FindAll()
        {
            var result = new ServiceResponse<List<GetPatientHospitalizationInformationVO>>();
            result.Success = false;
            result.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsNotFound", _applicationLanguageRepository, _cacheService);

            return result;
        }
        public override async Task<ServiceResponse<GetPatientHospitalizationInformationVO>> FindByID(long id)
        {
            ServiceResponse<GetPatientHospitalizationInformationVO> response = new ServiceResponse<GetPatientHospitalizationInformationVO>();
            try
            {
                PatientHospitalizationInformation entityResponse = await _entityRepository.FindByID(id);

                var recordData = new Record<PatientHospitalizationInformation>
                {
                    UserIdLogged = UserId,
                    RecordEntity = entityResponse
                };

                var validator = new PatientHospitalizationInformationSelectOneValidator(_userRepository);
                var validationResult = await validator.ValidateAsync(recordData);
                if (!validationResult.IsValid)
                {
                    response.Errors = validator.GetMapErros(validationResult.Errors);
                    response.Success = false;
                    response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                           ("ErrorValidator_User_Not_Permission", _applicationLanguageRepository, _cacheService);
                    return response;
                }
                response.Data = _mapper.Map<GetPatientHospitalizationInformationVO>(entityResponse);
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