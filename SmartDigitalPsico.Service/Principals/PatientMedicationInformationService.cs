using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Contratcs;
using SmartDigitalPsico.Domain.VO.Patient.PatientMedicationInformation;
using SmartDigitalPsico.Service.Generic;
using SmartDigitalPsico.Service.SystemDomains;

namespace SmartDigitalPsico.Service.Principals
{
    public class PatientMedicationInformationService : EntityBaseService<PatientMedicationInformation, AddPatientMedicationInformationVO, UpdatePatientMedicationInformationVO, GetPatientMedicationInformationVO, IPatientMedicationInformationRepository>, IPatientMedicationInformationService

    {
        private readonly IMapper _mapper;
        IConfiguration _configuration;
        private readonly IUserRepository _userRepository;
        private readonly IPatientMedicationInformationRepository _entityRepository;
        private readonly IPatientRepository _patientRepository;

        public PatientMedicationInformationService(IMapper mapper, IPatientMedicationInformationRepository entityRepository, IConfiguration configuration, IUserRepository userRepository, IPatientRepository patientRepository, IValidator<PatientMedicationInformation> entityValidator
            , IApplicationLanguageRepository applicationLanguageRepository, ICacheService cacheService)
            : base(mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _mapper = mapper;
            _configuration = configuration;
            _entityRepository = entityRepository;
            _userRepository = userRepository;
            _patientRepository = patientRepository;
        }
        public override async Task<ServiceResponse<GetPatientMedicationInformationVO>> Create(AddPatientMedicationInformationVO item)
        {
            ServiceResponse<GetPatientMedicationInformationVO> response = new ServiceResponse<GetPatientMedicationInformationVO>();
            try
            {
                PatientMedicationInformation entityAdd = _mapper.Map<PatientMedicationInformation>(item);


                #region Relationship
                 
                entityAdd.CreatedUserId = (this.UserId); 
                entityAdd.PatientId = item.PatientId;

                #endregion

                entityAdd.CreatedDate = DataHelper.GetDateTimeNow();
                entityAdd.ModifyDate = DataHelper.GetDateTimeNow();
                entityAdd.LastAccessDate = DataHelper.GetDateTimeNow();

                response = await base.Validate(entityAdd);

                if (response.Success)
                {
                    PatientMedicationInformation entityResponse = await _entityRepository.Create(entityAdd);

                    response.Data = _mapper.Map<GetPatientMedicationInformationVO>(entityResponse);
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

        public override async Task<ServiceResponse<GetPatientMedicationInformationVO>> Update(UpdatePatientMedicationInformationVO item)
        {
            ServiceResponse<GetPatientMedicationInformationVO> response = new ServiceResponse<GetPatientMedicationInformationVO>();
            try
            {
                PatientMedicationInformation entityUpdate = await _entityRepository.FindByID(item.Id);

                entityUpdate.ModifyDate = DataHelper.GetDateTimeNow();
                entityUpdate.LastAccessDate = DataHelper.GetDateTimeNow();
                 
                entityUpdate.ModifyUserId = this.UserId;

                #region Columns
                entityUpdate.Enable = item.Enable;
                //entityUpdate.Accreditation = item.Accreditation;
                entityUpdate.StartDate = item.StartDate;
                entityUpdate.EndDate = item.EndDate;
                entityUpdate.MainDrug = item.MainDrug;
                entityUpdate.Description = item.Description;
                entityUpdate.Dosage = item.Dosage;
                entityUpdate.Posology = item.Posology;
                #endregion Columns

                response = await base.Validate(entityUpdate);

                if (response.Success)
                {
                    PatientMedicationInformation entityResponse = await _entityRepository.Update(entityUpdate);

                    response.Data = _mapper.Map<GetPatientMedicationInformationVO>(entityResponse);
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
            response.Data = listResult.Select(c => _mapper.Map<GetPatientMedicationInformationVO>(c)).ToList();
            response.Success = true;
            response.Message = "Patients finded.";
            return response;
        }

        public async override Task<ServiceResponse<List<GetPatientMedicationInformationVO>>> FindAll()
        {
            var result = new ServiceResponse<List<GetPatientMedicationInformationVO>>();
            result.Success = false;
            result.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                       ("RegisterIsNotFound", base._applicationLanguageRepository, base._cacheService);

            return result;
        }
        public async override Task<ServiceResponse<GetPatientMedicationInformationVO>> FindByID(long id)
        {
            return await base.FindByID(id);
        }
    }
}