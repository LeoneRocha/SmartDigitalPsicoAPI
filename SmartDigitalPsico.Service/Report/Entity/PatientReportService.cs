using DocumentFormat.OpenXml.Wordprocessing;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator;
using SmartDigitalPsico.Domain.DTO.Patient.PatientRecord;
using SmartDigitalPsico.Domain.DTO.Report;
using SmartDigitalPsico.Domain.DTO.Report.Patient;
using SmartDigitalPsico.Service.DataEntity.Generic;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.Report.Entity
{
    public class PatientReportService
       : EntityBaseService<PatientRecord, AddPatientRecordDto, UpdatePatientRecordDto, GetPatientRecordDto, IPatientRecordRepository>, IPatientReportService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICryptoService _cryptoService;
        private readonly IPatientRepository _patientRepository;
        private readonly IReportServiceConfig _reportServiceConfig;

        public PatientReportService(IPatientRepositories repositories, IPatientRecordServiceConfig config, IReportServiceConfig reportServiceConfig)
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
            _reportServiceConfig = reportServiceConfig;
        }
        public async Task<ServiceResponse<PatientDetailReportDto>> GetPatientDetailsByIdAsync(long id)
        {
            ServiceResponse<PatientDetailReportDto> response = new ServiceResponse<PatientDetailReportDto>();
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
                response.Data = _mapper.Map<PatientDetailReportDto>(entityResponse);

                var listRecords = response.Data.PatientRecords.ToList();
                listRecords.ForEach(pr => pr.Annotation = _cryptoService.Decrypt(entityResponse.Medical?.SecurityKey ?? string.Empty, pr.Annotation));
                response.Data.PatientRecords = listRecords.ToArray();
                response.Success = true;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>("RegisterFind", _applicationLanguageRepository, _cacheService);

                await GenerateFileReport(response.Data);
            }
            catch (Exception)
            {
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>("RegisterIsNotFound", _applicationLanguageRepository, _cacheService);
            }
            return response;
        }

        private async Task GenerateFileReport(PatientDetailReportDto data)
        {
            var reportPatient = new List<object> { data };

            var infos = new List<object>();
            infos.AddRange(data.PatientAdditionalInformations.ToList());

            var hospitalizations = new List<object>();
            hospitalizations.AddRange(data.PatientHospitalizationInformations.ToList());

            var medications = new List<object>();
            medications.AddRange(data.PatientMedicationInformations.ToList());

            var records = new List<object>();
            records.AddRange(data.PatientRecords.ToList());

            var reportExcel = new ReportWorkbookDataDto()
            {
                FolderOutput = "Reports",
                FileName = $"PatientDetailReport_{data.Id}_{DataHelper.GetDateTimeNowBrazil().ToString("yyyyMMdd")}",
                Sheets = new List<ReportSheetDataDto>
                {
                    new ReportSheetDataDto { Order = 1, Name = "Patient", Rows = reportPatient,
                        PropertiesToIgnore = new List<string>(){ "Id", "Gender", "PatientAdditionalInformations", "PatientHospitalizationInformations", "PatientMedicationInformations" , "PatientRecords" } },
                    new ReportSheetDataDto  { Order = 2, Name = "Informations", Rows = infos },
                    new ReportSheetDataDto  { Order = 3, Name = "Hospitalizations", Rows = hospitalizations },
                    new ReportSheetDataDto  { Order = 4, Name = "Medications", Rows = medications },
                    new ReportSheetDataDto  { Order = 5, Name = "Records", Rows = records },
                }

            };
            await _reportServiceConfig.ExcelGeneratorService.Generate(reportExcel);

            var reportPDF = new ReportContentDto()
            {
                FileName = $"PatientDetailReport_{data.Id}_{DataHelper.GetDateTimeNowBrazil().ToString("yyyyMMdd")}",
                FolderOutput = "Reports_PDF",
                Title = "Report Patient",
                Pages = new List<ReportPageDataDto>()
                {
                    new ReportPageDataDto { Order = 1, Name = "Patient Detail", Rows = reportPatient, PageType =  EReportPageType.Text,
                        PropertiesToIgnore = new List<string>(){ "Id", "Gender", "PatientAdditionalInformations", "PatientHospitalizationInformations", "PatientMedicationInformations" , "PatientRecords" } },
                    new ReportPageDataDto  { Order = 2, Name = "Informations", Rows = infos },
                    new ReportPageDataDto  { Order = 3, Name = "Hospitalizations", Rows = hospitalizations },
                    new ReportPageDataDto  { Order = 4, Name = "Medications", Rows = medications },
                    new ReportPageDataDto  { Order = 5, Name = "Records", Rows = records },
                }
            };
            _reportServiceConfig.PdfReportService.Generate(reportPDF);
        }
    }
}
