using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Report;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator;
using SmartDigitalPsico.Domain.VO.Patient.PatientRecord;
using SmartDigitalPsico.Domain.VO.Report.Patient;
using SmartDigitalPsico.Service.DataEntity.Generic;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;

namespace SmartDigitalPsico.Service.Report.Entity
{
    public class PatientReportService
       : EntityBaseService<PatientRecord, AddPatientRecordVO, UpdatePatientRecordVO, GetPatientRecordVO, IPatientRecordRepository>, IPatientReportService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICryptoService _cryptoService;
        private readonly IPatientRepository _patientRepository;

        public PatientReportService(IPatientRepositories repositories, IPatientRecordServiceConfig config)
        : base(
              config.SharedServices,
              config.SharedDependenciesConfig,
              config.SharedRepositories,
              repositories.PatientRecordRepository,
              config.EntityValidator)
        {
            _userRepository = repositories.SharedRepositories.UserRepository;
            _cryptoService = config.SharedServices.CryptoService;
            _patientRepository = repositories.PatientRepository;
        }

        public async Task<ServiceResponse<PatientDetailReportVO>> GetPatientDetailsByIdAsync(long id)
        {
            ServiceResponse<PatientDetailReportVO> response = new ServiceResponse<PatientDetailReportVO>();
            try
            {
                Patient entityResponse = await _patientRepository.GetPatientDetailsByIdAsync(id);

                if (entityResponse == null)
                {
                    response.Success = false;
                    response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>("RegisterIsNotFound", _applicationLanguageRepository, _cacheService);
                    return response;
                }

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
                    response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>("ErrorValidator_User_Not_Permission", _applicationLanguageRepository, _cacheService);
                    return response;
                } 
                response.Data = _mapper.Map<PatientDetailReportVO>(entityResponse);

                var listRecords = response.Data.PatientRecords.ToList();
                listRecords.ForEach(pr => pr.Annotation = _cryptoService.Decrypt(entityResponse.Medical?.SecurityKey ?? string.Empty, pr.Annotation));
                response.Data.PatientRecords = listRecords.ToArray();
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
