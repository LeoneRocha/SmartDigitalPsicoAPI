using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Contratcs;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile;
using SmartDigitalPsico.Core.SDK.Domain.VO;
using SmartDigitalPsico.Core.SDK.Domain.Validation.Helper;
using SmartDigitalPsico.Domain.Constants.I18nKeyConstants;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    /// <summary>
    /// Classe responsÃ¡vel por MedicalFileService.
    /// Responsabilidade: serviÃ§o de entidade de negÃ³cio.
    /// RelaÃ§Ã£o: orquestra repositÃ³rios, validators e mapeamentos.
    /// </summary>
    public class MedicalFileService : SmartDigitalPsico.Service.DataEntity.Generic.EntityBaseService<MedicalFile, GetMedicalFileDto>, IMedicalFileService
    {
        private readonly IConfiguration _configuration;
        private readonly IFileManager _filePersistor;
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// MÃ©todo MedicalFileService: executa a operaÃ§Ã£o MedicalFileService.
        /// </summary>
        public MedicalFileService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IMedicalFileRepository entityRepository,
            IValidator<MedicalFile> entityValidator,
            IFileManager filePersistor
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
            _configuration = sharedDependenciesConfig.Configuration;
            _filePersistor = filePersistor;
            _userRepository = sharedRepositories.UserRepository;
        }
        /// <summary>
        /// MÃ©todo FindAll: consulta e retorna dados.
        /// </summary>
        public override async Task<ServiceResponse<List<GetMedicalFileDto>>> FindAll()
        {
            var result = new ServiceResponse<List<GetMedicalFileDto>>();
            result.Success = false;
            result.Message = await base.GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageKeyConstants.RegisterIsNotFound);
            return result;
        }

        /// <summary>
        /// MÃ©todo FindByID: consulta e retorna dados.
        /// </summary>
        public async override Task<ServiceResponse<GetMedicalFileDto>> FindByID(long id)
        {
            ServiceResponse<GetMedicalFileDto> response = await base.FindByID(id);

            if (response.Data != null && string.IsNullOrEmpty(response.Data.FilePath))
            {
                var fileName = response.Data.FileName ?? string.Empty;
                await SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.GetFromByteSaveTemp(response.Data.FileData, fileName, _configuration);
                response.Data.FileUrl = SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.GetFilePath(SmartDigitalPsico.Core.SDK.Domain.Helpers.DirectoryHelper.GetDiretoryTemp(_configuration), fileName);
            }
            return response;
        }

        /// <summary>
        /// MÃ©todo FindAllByMedical: consulta e retorna dados.
        /// </summary>
        public async Task<ServiceResponse<List<GetMedicalFileDto>>> FindAllByMedical(long medicalId)
        {
            ServiceResponse<List<GetMedicalFileDto>> response = new ServiceResponse<List<GetMedicalFileDto>>();

            var listResult = await ((IMedicalFileRepository)_entityRepository).FindAllByMedical(medicalId);

            var recordsList = new RecordsList<MedicalFile>
            {
                UserIdLogged = UserId,
                Records = listResult,

            };
            var validator = new MedicalFileSelectListValidator(_userRepository);
            var validationResult = await validator.ValidateAsync(recordsList);

            if (!validationResult.IsValid)
            {
                response.Errors = HelperValidation.ConvertValidationFailureListToErroResponse(validationResult.Errors);
                response.Success = false; 
                response.Message = await base.GetLocalization(ErrorValidatorKeyConstants.ErrorValidator_User_Not_Permission, ErrorValidatorMenssageConstants.ErrorValidator_User_Not_Permission);
                return response;
            }

            if (listResult.Count == 0)
            {
                response.Success = false; 
                response.Message = await base.GetLocalization(GeneralLanguageKeyConstants.RegisterIsNotFound, GeneralLanguageMenssageConstants.RegisterIsNotFound); 
                return response;
            }
            response.Data = listResult.Select(c => _mapper.Map<GetMedicalFileDto>(c)).ToList();
            response.Success = true;  
            response.Message = await base.GetLocalization(GeneralLanguageKeyConstants.RegisterIsFound, GeneralLanguageMenssageConstants.RegisterIsFound);

            return response;
        }

        /// <summary>
        /// MÃ©todo Update: atualiza um registro/recurso existente.
        /// </summary>
        public override Task<ServiceResponse<GetMedicalFileDto>> Update(SmartDigitalPsico.Core.SDK.Domain.Interfaces.IEntityDto item)
        {
            throw new NotImplementedException("Not Permission");
        }

        /// <summary>
        /// MÃ©todo PostFileAsync: executa a operaÃ§Ã£o PostFileAsync.
        /// </summary>
        public async Task<ServiceResponse<GetMedicalFileDto>> PostFileAsync(AddMedicalFileDto entity)
        {
            ServiceResponse<GetMedicalFileDto> response = new ServiceResponse<GetMedicalFileDto>();

            IFormFile? fileData;
            if (entity != null)
            {
                fileData = entity.FileDetails;
                if (fileData != null)
                {
                    entity.FilePath = fileData.FileName;
                    entity.FileContentType = fileData.ContentType;
                    entity.FileExtension = SmartDigitalPsico.Core.SDK.Domain.Helpers.FileHelper.GetFileExtension(fileData.ContentType);
                    entity.FileSizeKB = fileData.Length / 1024;
                }

                MedicalFile entityAdd = _mapper.Map<MedicalFile>(entity);

                entityAdd.FileName = entity.FilePath;
                entityAdd.MedicalId = entity.MedicalId;

                entityAdd.CreatedDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                entityAdd.ModifyDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                entityAdd.LastAccessDate = SmartDigitalPsico.Core.SDK.Domain.Helpers.DateHelper.GetDateTimeNowFromUtc();
                entityAdd.Enable = true;

                entityAdd.CreatedUserId = UserId;

                response = await base.Validate(entityAdd);
                if (response.Success)
                {
                    entityAdd.FilePath = await _filePersistor.PersistFile(fileData, entityAdd, "medicalfiles", entity.MedicalId.ToString());
                    MedicalFile entityResponse = await ((IMedicalFileRepository)_entityRepository).Create(entityAdd);
                    response.Data = _mapper.Map<GetMedicalFileDto>(entityResponse);
                }
            }

            return response;
        }

        /// <summary>
        /// MÃ©todo DownloadFileById: executa a operaÃ§Ã£o DownloadFileById.
        /// </summary>
        public async Task<GetMedicalFileDto> DownloadFileById(long fileId)
        {
            MedicalFile? fileEntity = await ((IMedicalFileRepository)_entityRepository).FindByID(fileId);

            var resultData = await _filePersistor.DownloadFileById(fileEntity, fileEntity.MedicalId.ToString()) as MedicalFile;
            if (resultData != null)
            {
                fileEntity.FileData = resultData.FileData;
            }
            GetMedicalFileDto resultVO = _mapper.Map<GetMedicalFileDto>(fileEntity);
            return resultVO;
        }
        /// <summary>
        /// MÃ©todo Delete: remove ou cancela um registro/recurso.
        /// </summary>
        public async override Task<ServiceResponse<bool>> Delete(long id)
        {
            MedicalFile? fileEntity = await ((IMedicalFileRepository)_entityRepository).FindByID(id);

            bool result = await _filePersistor.DeleteFile(fileEntity, fileEntity.MedicalId.ToString());
            if (result)
            {
                return new ServiceResponse<bool>() { Success = await ((IMedicalFileRepository)_entityRepository).Delete(id) };
            }
            return new ServiceResponse<bool>() { Success = false };
        }
    }
}

