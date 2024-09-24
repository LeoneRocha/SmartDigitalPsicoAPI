using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.DTO.Patient.PatientRecord;
using SmartDigitalPsico.Domain.DTO.Report;
using SmartDigitalPsico.Domain.DTO.Report.Enitty;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Service.DataEntity.Generic;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;

namespace SmartDigitalPsico.Service.Report.Entity
{
    public class PatientReportService
       : EntityBaseService<PatientRecord, AddPatientRecordDto, UpdatePatientRecordDto, GetPatientRecordDto, IPatientRecordRepository>, IPatientReportService
    {
        private readonly IUserRepository _userRepository;
        private readonly ICryptoService _cryptoService;
        private readonly IPatientRepository _patientRepository;
        private readonly IReportServiceConfig _reportServiceConfig;
        private readonly IPatientRecordServiceConfig _config;

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
            _config = config;
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
            }
            catch (Exception)
            {
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>("RegisterIsNotFound", _applicationLanguageRepository, _cacheService);
            }
            return response;
        }

        private async Task<(string, string)> GenerateFileReport(PatientDetailReportDto data, EReportOutputType eReportOutputType)
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

            switch (eReportOutputType)
            {
                case EReportOutputType.Excel:
                    return await GenerateExcelReport(data, reportPatient, infos, hospitalizations, medications, records);
                case EReportOutputType.Pdf:
                    return await GeneratePdfReport(data, reportPatient, infos, hospitalizations, medications, records);
                default:
                    break;
            }
            return (string.Empty, string.Empty);
        }
        private async Task<(string, string)> GeneratePdfReport(PatientDetailReportDto data, List<object> reportPatient, List<object> infos, List<object> hospitalizations, List<object> medications, List<object> records)
        {
            var reportPDF = new ReportPageContentDto()
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
            var result = await _reportServiceConfig.PdfReportService.Generate(reportPDF);
            return (result, reportPDF.FileName);
        }

        private async Task<(string, string)> GenerateExcelReport(PatientDetailReportDto data, List<object> reportPatient, List<object> infos, List<object> hospitalizations, List<object> medications, List<object> records)
        {
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

            var result = await _reportServiceConfig.ExcelGeneratorService.Generate(reportExcel);
            return (result, reportExcel.FileName);
        }

        public async Task<FileContentResult> DownloadReportPatientDetailsById(long id, EReportOutputType eReportOutputType)
        {
            ServiceResponse<PatientDetailReportDto> responseData = await GetPatientDetailsByIdAsync(id);
            try
            {
                if (responseData.Data != null)
                {
                    var responseFile = await GenerateFileReport(responseData.Data, eReportOutputType);

                    //Copy Temp folder 
                    var folderOuput = Path.Combine(DirectoryHelper.GetDiretoryTemp(_config.SharedDependenciesConfig.Configuration), responseFile.Item2);
                    folderOuput = FileHelper.NormalizePath(folderOuput);

                    await FileHelper.CopyFile(responseFile.Item1, folderOuput);
                    //Delete origin 
                    await FileHelper.Delete(responseFile.Item1);

                    var response = FileHelper.ProccessDownloadToBrowser(folderOuput);
                    return response;
                }
            }
            catch (Exception ex)
            {
                _config.SharedDependenciesConfig.Logger.Error(ex, "Erro ao gerar PDF");
            }
            return new FileContentResult([], "application/octet-stream");
        }
    }
}
