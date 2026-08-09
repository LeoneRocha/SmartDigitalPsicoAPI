using FluentValidation;
using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Validation;
using SmartDigitalPsico.Domain.DTO.Patient.ADD;
using SmartDigitalPsico.Domain.DTO.Patient.GET;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Core.SDK.Domain.Validation.Helper;
using SmartDigitalPsico.Core.SDK.Domain.Constants.I18nKeyConstants;

using SmartDigitalPsico.Domain.Interfaces.Common;
using SmartDigitalPsico.Domain.Interfaces.Patient;
using SmartDigitalPsico.Domain.Interfaces.User;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Service
{
    /// <summary>
    /// Classe responsável por PatientFileService.
    /// Responsabilidade: serviço de entidade de negócio.
    /// Relação: orquestra repositórios, validators e mapeamentos.
    /// </summary>
    public class PatientFileService : SmartDigitalPsico.Service.EntityBaseService<PatientFile, GetPatientFileDto>, IPatientFileService

    {
        private readonly IFileManagerService _filePersistor;
        private readonly IPatientRepository _patientRepository;
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// Método PatientFileService: executa a operação PatientFileService.
        /// </summary>
        public PatientFileService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IPatientFileRepository entityRepository,
            IValidator<PatientFile> entityValidator,
            IFileManagerService filePersistor,
            IPatientRepository patientRepository
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
            _filePersistor = filePersistor;
            _patientRepository = patientRepository;
            _userRepository = sharedRepositories.UserRepository;
        }

        /// <summary>
        /// Método Delete: remove ou cancela um registro/recurso.
        /// </summary>
        public override Task<ServiceResponse<bool>> Delete(long id)
        {
            return base.EnableOrDisable(id);
        }

        /// <summary>
        /// Método PostFileAsync: executa a operação PostFileAsync.
        /// </summary>
        public async Task<bool> PostFileAsync(AddPatientFileDto entity)
        {
            ServiceResponse<GetPatientFileDto> response = new ServiceResponse<GetPatientFileDto>();
            if (entity != null)
            {

                IFormFile fileData;

                fileData = entity.FileDetails;
                if (fileData != null)
                {
                    entity.FilePath = fileData.FileName;
                    entity.FileContentType = fileData.ContentType;
                    entity.FileExtension = SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.GetFileExtension(fileData.ContentType);
                    entity.FileSizeKB = fileData.Length / 1024;
                }

                PatientFile entityAdd = _mapper.Map<PatientFile>(entity);
                entityAdd.FileName = entity.FilePath;
                #region Relationship

                entityAdd.PatientId = entity.PatientId;

                Patient patient = await _patientRepository.FindByID(entity.PatientId);

                #endregion Relationship

                entityAdd.CreatedDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                entityAdd.ModifyDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                entityAdd.LastAccessDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                entityAdd.Enable = true;

                entityAdd.CreatedUserId = UserId;
                if (response.Success)
                {
                    entityAdd.FilePath = await _filePersistor.PersistFile(fileData, entityAdd, "patientfiles", $"{patient.MedicalId}_{entity.PatientId}");
                    await ((IPatientFileRepository)_entityRepository).Create(entityAdd);
                }

            }
            return response.Success;
        }

        /// <summary>
        /// Método DownloadFileById: executa a operação DownloadFileById.
        /// </summary>
        public async Task<GetPatientFileDto> DownloadFileById(long fileId)
        {
            var fileEntity = await ((IPatientFileRepository)_entityRepository).FindByID(fileId);

            #region Relationship

            Patient patient = await _patientRepository.FindByID(fileEntity.PatientId);

            #endregion Relationship

            var resultData = await _filePersistor.DownloadFileById(fileEntity, $"{patient.MedicalId}_{fileEntity.PatientId}") as PatientFile;
            if (resultData != null)
            {
                fileEntity.FileData = resultData.FileData;
            }
            GetPatientFileDto resultVO = _mapper.Map<GetPatientFileDto>(fileEntity);

            return resultVO;
        }

        /// <summary>
        /// Método FindAllByPatient: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<List<GetPatientFileDto>>> FindAllByPatient(long patientId)
        {
            ServiceResponse<List<GetPatientFileDto>> response = new ServiceResponse<List<GetPatientFileDto>>();

            var listResult = await ((IPatientFileRepository)_entityRepository).FindAllByPatient(patientId);

            var recordsList = new RecordsList<PatientFile>
            {
                UserIdLogged = UserId,
                Records = listResult,

            };
            var validator = new PatientFileSelectListValidator(_userRepository);
            var validationResult = await validator.ValidateAsync(recordsList);

            if (!validationResult.IsValid)
            {
                response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
                response.Success = false;
                response.Message = await GetLocalization(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission);

                return response;
            }

            if (listResult.Count == 0)
            {
                response.Success = false;
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
                return response;
            }
            response.Data = listResult.Select(c => _mapper.Map<GetPatientFileDto>(c)).ToList();
            response.Success = true;
            response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound);
            return response;

        }

        /// <summary>
        /// Método FindByID: consulta e retorna dados.
        /// </summary>
        public override async Task<ServiceResponse<GetPatientFileDto>> FindByID(long id)
        {
            ServiceResponse<GetPatientFileDto> response = new ServiceResponse<GetPatientFileDto>();
            try
            {
                PatientFile entityResponse = await ((IPatientFileRepository)_entityRepository).FindByID(id);

                var recordData = new Record<PatientFile>
                {
                    UserIdLogged = UserId,
                    RecordEntity = entityResponse
                };

                var validator = new PatientFileSelectOneValidator(_userRepository);
                var validationResult = await validator.ValidateAsync(recordData);
                if (!validationResult.IsValid)
                {
                    response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
                    response.Success = false;
                    response.Message = await GetLocalization(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission);
                    return response;
                }
                response.Data = _mapper.Map<GetPatientFileDto>(entityResponse);
                response.Success = true;
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound);
            }
            catch (Exception)
            {
                response.Success = false;
                response.Message = await GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound);
            }
            return response;
        }
    }
}
