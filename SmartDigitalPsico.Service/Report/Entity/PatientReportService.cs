using DocumentFormat.OpenXml.Wordprocessing;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.PatientValidations.OneValidator;
using SmartDigitalPsico.Domain.VO.Patient.PatientRecord;
using SmartDigitalPsico.Domain.VO.Report;
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
        private readonly IExcelGeneratorService _excelGeneratorService;
        private readonly IPdfReportService _pdfReportService;

        public PatientReportService(IPatientRepositories repositories, IPatientRecordServiceConfig config, IExcelGeneratorService excelGeneratorService, IPdfReportService pdfReportService)
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
            _excelGeneratorService = excelGeneratorService;
            _pdfReportService = pdfReportService;
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

                await GenerateFileReport(response.Data);
            }
            catch (Exception)
            {
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>("RegisterIsNotFound", _applicationLanguageRepository, _cacheService);
            }
            return response;
        }

        private async Task GenerateFileReport(PatientDetailReportVO data)
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

            var reportExcel = new ReportWorkbookDataVO()
            {
                FolderOutput = "Reports",
                FileName = $"PatientDetailReport_{data.Id}_{DataHelper.GetDateTimeNowBrazil().ToString("yyyyMMdd")}",
                Sheets = new List<ReportSheetDataVO>
                {
                    new ReportSheetDataVO { Order = 1, Name = "Patient", Rows = reportPatient,
                        PropertiesToIgnore = new List<string>(){ "Id", "Gender", "PatientAdditionalInformations", "PatientHospitalizationInformations", "PatientMedicationInformations" , "PatientRecords" } },
                    new ReportSheetDataVO  { Order = 2, Name = "Informations", Rows = infos },
                    new ReportSheetDataVO  { Order = 3, Name = "Hospitalizations", Rows = hospitalizations },
                    new ReportSheetDataVO  { Order = 4, Name = "Medications", Rows = medications },
                    new ReportSheetDataVO  { Order = 5, Name = "Records", Rows = records },
                }

            };
            await _excelGeneratorService.Generate(reportExcel);

            var reportPDF = new ReportContent()
            {
                FileName = $"PatientDetailReport_{data.Id}_{DataHelper.GetDateTimeNowBrazil().ToString("yyyyMMdd")}",
                FolderOutput = "Reports_PDF",
                Title = "Report Patient",
                Pages = new List<ReportPageDataVO>()
                {
                    new ReportPageDataVO { Order = 1, Name = "Patient Detail", Rows = reportPatient, PageType =  EReportPageType.Text,
                        PropertiesToIgnore = new List<string>(){ "Id", "Gender", "PatientAdditionalInformations", "PatientHospitalizationInformations", "PatientMedicationInformations" , "PatientRecords" } },
                    new ReportPageDataVO  { Order = 2, Name = "Informations", Rows = infos },
                    new ReportPageDataVO  { Order = 3, Name = "Hospitalizations", Rows = hospitalizations },
                    new ReportPageDataVO  { Order = 4, Name = "Medications", Rows = medications },
                    new ReportPageDataVO  { Order = 5, Name = "Records", Rows = records },
                }
            };
            _pdfReportService.Generate(reportPDF);
        }
    }
}
