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
using SmartDigitalPsico.Domain.VO.Patient.PatientMedicationInformation;
using SmartDigitalPsico.Service.Generic;
using SmartDigitalPsico.Service.SystemDomains;

namespace SmartDigitalPsico.Service.Principals
{
    public class PatientMedicationInformationService : EntityBaseService<PatientMedicationInformation, AddPatientMedicationInformationVO, UpdatePatientMedicationInformationVO, GetPatientMedicationInformationVO, IPatientMedicationInformationRepository>, IPatientMedicationInformationService

    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IPatientMedicationInformationRepository _entityRepository;

        public PatientMedicationInformationService(IMapper mapper,
            IPatientMedicationInformationRepository entityRepository, IUserRepository userRepository
            , IValidator<PatientMedicationInformation> entityValidator
            , IApplicationLanguageRepository applicationLanguageRepository, ICacheService cacheService)
            : base(mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _mapper = mapper;
            _entityRepository = entityRepository;
            _userRepository = userRepository;
        }
        public override async Task<ServiceResponse<GetPatientMedicationInformationVO>> Create(AddPatientMedicationInformationVO item)
        {

            PatientMedicationInformation entityAdd = _mapper.Map<PatientMedicationInformation>(item);

            #region Relationship

            entityAdd.CreatedUserId = (this.UserId);
            entityAdd.PatientId = item.PatientId;

            #endregion

            entityAdd.CreatedDate = DataHelper.GetDateTimeNow();
            entityAdd.ModifyDate = DataHelper.GetDateTimeNow();
            entityAdd.LastAccessDate = DataHelper.GetDateTimeNow();

            ServiceResponse<GetPatientMedicationInformationVO> response = await base.Validate(entityAdd);

            if (response.Success)
            {
                PatientMedicationInformation entityResponse = await _entityRepository.Create(entityAdd);

                response.Data = _mapper.Map<GetPatientMedicationInformationVO>(entityResponse);
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                   ("RegisterCreated", base._applicationLanguageRepository, base._cacheService);
            }

            return response;
        }

        public override async Task<ServiceResponse<GetPatientMedicationInformationVO>> Update(UpdatePatientMedicationInformationVO item)
        { 
            PatientMedicationInformation entityUpdate = await _entityRepository.FindByID(item.Id);

            entityUpdate.ModifyDate = DataHelper.GetDateTimeNow();
            entityUpdate.LastAccessDate = DataHelper.GetDateTimeNow();

            entityUpdate.ModifyUserId = this.UserId;

            #region Columns
            entityUpdate.Enable = item.Enable;
            entityUpdate.StartDate = item.StartDate;
            entityUpdate.EndDate = item.EndDate;
            entityUpdate.MainDrug = item.MainDrug;
            entityUpdate.Description = item.Description;
            entityUpdate.Dosage = item.Dosage;
            entityUpdate.Posology = item.Posology;
            #endregion Columns

            ServiceResponse<GetPatientMedicationInformationVO> response = await base.Validate(entityUpdate);

            if (response.Success)
            {
                PatientMedicationInformation entityResponse = await _entityRepository.Update(entityUpdate);

                response.Data = _mapper.Map<GetPatientMedicationInformationVO>(entityResponse);
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                   ("RegisterUpdated", base._applicationLanguageRepository, base._cacheService);
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetPatientMedicationInformationVO>>> FindAllByPatient(long patientId)
        {
            ServiceResponse<List<GetPatientMedicationInformationVO>> response = new ServiceResponse<List<GetPatientMedicationInformationVO>>();

            var listResult = await _entityRepository.FindAllByPatient(patientId);

            var recordsList = new RecordsList<PatientMedicationInformation>
            {
                UserIdLogged = base.UserId,
                Records = listResult

            };
            var validator = new PatientMedicationInformationSelectListValidator(_userRepository);
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
            response.Data = listResult.Select(c => _mapper.Map<GetPatientMedicationInformationVO>(c)).ToList();
            response.Success = true;
            response.Message = "Patients finded.";
            return response;
        }

        public async override Task<ServiceResponse<List<GetPatientMedicationInformationVO>>> FindAll()
        {
            var result = new ServiceResponse<List<GetPatientMedicationInformationVO>>();
            result.Success = false;
            result.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsNotFound", base._applicationLanguageRepository, base._cacheService);

            return result;
        }

        public override async Task<ServiceResponse<GetPatientMedicationInformationVO>> FindByID(long id)
        {
            ServiceResponse<GetPatientMedicationInformationVO> response = new ServiceResponse<GetPatientMedicationInformationVO>();
            try
            {
                PatientMedicationInformation entityResponse = await _entityRepository.FindByID(id);

                var recordData = new Record<PatientMedicationInformation>
                {
                    UserIdLogged = base.UserId,
                    RecordEntity = entityResponse
                };

                var validator = new PatientMedicationInformationSelectOneValidator(_userRepository);
                var validationResult = await validator.ValidateAsync(recordData);
                if (!validationResult.IsValid)
                {
                    response.Errors = validator.GetMapErros(validationResult.Errors);
                    response.Success = false;
                    response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                           ("ErrorValidator_User_Not_Permission", base._applicationLanguageRepository, base._cacheService);
                    return response;
                }
                response.Data = _mapper.Map<GetPatientMedicationInformationVO>(entityResponse);
                response.Success = true;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>("RegisterFind", base._applicationLanguageRepository, base._cacheService);
            }
            catch (Exception)
            {
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>("RegisterIsNotFound", base._applicationLanguageRepository, base._cacheService);
            }
            return response;
        }
    }
}