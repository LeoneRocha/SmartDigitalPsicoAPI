using Microsoft.AspNetCore.Mvc;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.DTO.Patient.PatientRecord;
using SmartDigitalPsico.Domain.DTO.Report.Enitty;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Core.SDK.Domain.Validation.Helper;
using SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator;
using SmartDigitalPsico.Core.SDK.Domain.VO;

namespace SmartDigitalPsico.Service.Report.Entity
{
    /// <summary>
    /// Classe responsável por PatientReportService.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class PatientReportService
       : SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService<PatientRecord, GetPatientRecordDto>, IPatientReportService
    {
        private readonly IUserRepository _userRepository;
        private readonly SmartDigitalPsico.Core.SDK.Domain.Interfaces.Security.ICryptoService _cryptoService;
        private readonly IPatientRepository _patientRepository;
        private readonly IReportServiceConfig _reportServiceConfig;
        private readonly IPatientRecordServiceConfig _config;

        /// <summary>
        /// Método PatientReportService: executa a operação PatientReportService.
        /// </summary>
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
        /// <summary>
        /// Método GetPatientDetailsByIdAsync: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<PatientDetailReportDto>> GetPatientDetailsByIdAsync(long id)
        {
            ServiceResponse<PatientDetailReportDto> response = new ServiceResponse<PatientDetailReportDto>();
            try
            {
                Patient entityResponse = await _patientRepository.GetPatientDetailsByIdAsync(id);

                if (entityResponse == null)
                {
                    response.Success = false;                    
                    response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
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
                    response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
                    response.Success = false;
                    response.Message = await GetLocalization(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission);                    
                    return response;
                }
                response.Data = _mapper.Map<PatientDetailReportDto>(entityResponse);

                var listRecords = response.Data.PatientRecords.ToList();
                listRecords.ForEach(pr => pr.Annotation = _cryptoService.Decrypt(entityResponse.Medical?.SecurityKey ?? string.Empty, pr.Annotation));
                response.Data.PatientRecords = listRecords.ToArray();
                response.Success = true; 
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterFind, GeneralLanguageMenssageConstants.RegisterFind);
            }
            catch (Exception)
            {
                response.Success = false;                
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
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
            var reportPDF = new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageContentDto()
            {
                FileName = $"PatientDetailReport_{data.Id}_{SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowBrazil().ToString("yyyyMMdd")}",
                FolderOutput = "Reports_PDF",
                Title = "Report Patient",
                Pages = new List<SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageDataDto>()
                {
                    new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageDataDto { Order = 1, Name = "Patient Detail", Rows = reportPatient, PageType =  SmartDigitalPsico.Core.SDK.Domain.Enuns.EReportPageType.Text,
                        PropertiesToIgnore = new List<string>(){ "Id", "Gender", "PatientAdditionalInformations", "PatientHospitalizationInformations", "PatientMedicationInformations" , "PatientRecords" } },
                    new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageDataDto  { Order = 2, Name = "Informations", Rows = infos },
                    new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageDataDto  { Order = 3, Name = "Hospitalizations", Rows = hospitalizations },
                    new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageDataDto  { Order = 4, Name = "Medications", Rows = medications },
                    new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportPageDataDto  { Order = 5, Name = "Records", Rows = records },
                }
            };
            var result = await _reportServiceConfig.PdfReportService.Generate(reportPDF);
            return (result, reportPDF.FileName);
        }

        private async Task<(string, string)> GenerateExcelReport(PatientDetailReportDto data, List<object> reportPatient, List<object> infos, List<object> hospitalizations, List<object> medications, List<object> records)
        {
            var reportExcel = new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportWorkbookDataDto()
            {
                FolderOutput = "Reports",
                FileName = $"PatientDetailReport_{data.Id}_{SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowBrazil().ToString("yyyyMMdd")}",
                Sheets = new List<SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportSheetDataDto>
        {
            new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportSheetDataDto { Order = 1, Name = "Patient", Rows = reportPatient,
                PropertiesToIgnore = new List<string>(){ "Id", "Gender", "PatientAdditionalInformations", "PatientHospitalizationInformations", "PatientMedicationInformations" , "PatientRecords" } },
            new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportSheetDataDto  { Order = 2, Name = "Informations", Rows = infos },
            new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportSheetDataDto  { Order = 3, Name = "Hospitalizations", Rows = hospitalizations },
            new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportSheetDataDto  { Order = 4, Name = "Medications", Rows = medications },
            new SmartDigitalPsico.Core.SDK.Domain.DTO.Report.ReportSheetDataDto  { Order = 5, Name = "Records", Rows = records },
        }
            };

            var result = await _reportServiceConfig.ExcelGeneratorService.Generate(reportExcel);
            return (result, reportExcel.FileName);
        }

        /// <summary>
        /// Método DownloadReportPatientDetailsById: executa a operação DownloadReportPatientDetailsById.
        /// </summary>
        public async Task<FileContentResult> DownloadReportPatientDetailsById(long id, EReportOutputType eReportOutputType)
        {
            ServiceResponse<PatientDetailReportDto> responseData = await GetPatientDetailsByIdAsync(id);
            try
            {
                if (responseData.Data != null)
                {
                    var responseFile = await GenerateFileReport(responseData.Data, eReportOutputType);

                    //Copy Temp folder 
                    var folderOuput = Path.Combine(SmartDigitalPsico.Core.SDK.Domain.Helpers.DirectoryHelper.GetDiretoryTemp(_config.SharedDependenciesConfig.Configuration), responseFile.Item2);
                    folderOuput = SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.NormalizePath(folderOuput);

                    await SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.CopyFile(responseFile.Item1, folderOuput);
                    //Delete origin 
                    await SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.Delete(responseFile.Item1);

                    var response = SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.ProccessDownloadToBrowser(folderOuput);
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
