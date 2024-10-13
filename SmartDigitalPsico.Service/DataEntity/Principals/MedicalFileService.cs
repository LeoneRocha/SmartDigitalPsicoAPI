using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.Contratcs;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile;
using SmartDigitalPsico.Service.DataEntity.Generic;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;
using SmartDigitalPsico.Domain.VO;
using SmartDigitalPsico.Domain.Validation.Helper;

namespace SmartDigitalPsico.Service.DataEntity.Principals
{
    public class MedicalFileService : EntityBaseService<MedicalFile, AddMedicalFileDto, UpdateMedicalFileDto, GetMedicalFileDto, IMedicalFileRepository>, IMedicalFileService
    {
        private readonly IConfiguration _configuration;
        private readonly IFileManager _filePersistor;
        private readonly IUserRepository _userRepository;

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
        public override async Task<ServiceResponse<List<GetMedicalFileDto>>> FindAll()
        {
            var result = new ServiceResponse<List<GetMedicalFileDto>>();
            result.Success = false;
            result.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>("RegisterIsNotFound", _applicationLanguageRepository, _cacheService);

            return result;
        }

        public async override Task<ServiceResponse<GetMedicalFileDto>> FindByID(long id)
        {
            ServiceResponse<GetMedicalFileDto> response = await base.FindByID(id);

            if (response.Data != null && string.IsNullOrEmpty(response.Data.FilePath))
            {
                await FileHelper.GetFromByteSaveTemp(response.Data.FileData, response.Data.FileName, _configuration);
                response.Data.FileUrl = FileHelper.GetFilePath(DirectoryHelper.GetDiretoryTemp(_configuration), response.Data.FileName ?? string.Empty);
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetMedicalFileDto>>> FindAllByMedical(long medicalId)
        {
            ServiceResponse<List<GetMedicalFileDto>> response = new ServiceResponse<List<GetMedicalFileDto>>();

            var listResult = await _entityRepository.FindAllByMedical(medicalId);

            var recordsList = new RecordsList<MedicalFile>
            {
                UserIdLogged = UserId,
                Records = listResult,

            };
            var validator = new MedicalFileSelectListValidator(_userRepository);
            var validationResult = await validator.ValidateAsync(recordsList);

            if (!validationResult.IsValid)
            {
                response.Errors = HelperValidation.GetMapErros(validationResult.Errors);
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
            response.Data = listResult.Select(c => _mapper.Map<GetMedicalFileDto>(c)).ToList();
            response.Success = true;
            response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsFound", _applicationLanguageRepository, _cacheService);

            return response;
        }

        public override Task<ServiceResponse<GetMedicalFileDto>> Update(UpdateMedicalFileDto item)
        {
            throw new NotImplementedException("Not Permission");
        }

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
                    entity.FileExtension = FileHelper.GetFileExtension(fileData.ContentType);
                    entity.FileSizeKB = fileData.Length / 1024;
                }

                MedicalFile entityAdd = _mapper.Map<MedicalFile>(entity);

                entityAdd.FileName = entity.FilePath;
                entityAdd.MedicalId = entity.MedicalId;

                entityAdd.CreatedDate = DataHelper.GetDateTimeNow();
                entityAdd.ModifyDate = DataHelper.GetDateTimeNow();
                entityAdd.LastAccessDate = DataHelper.GetDateTimeNow();
                entityAdd.Enable = true;

                entityAdd.CreatedUserId = UserId;

                response = await base.Validate(entityAdd);
                if (response.Success)
                {
                    entityAdd.FilePath = await _filePersistor.PersistFile(fileData, entityAdd, "medicalfiles", entity.MedicalId.ToString());
                    MedicalFile entityResponse = await _entityRepository.Create(entityAdd);
                    if (response.Data != null)
                        response.Data.Id = entityResponse.Id;
                }
            }

            return response;
        }

        public async Task<GetMedicalFileDto> DownloadFileById(long fileId)
        {
            MedicalFile? fileEntity = await _entityRepository.FindByID(fileId);

            var resultData = await _filePersistor.DownloadFileById(fileEntity, fileEntity.MedicalId.ToString()) as MedicalFile;
            if (resultData != null)
            {
                fileEntity.FileData = resultData.FileData;
            }
            GetMedicalFileDto resultVO = _mapper.Map<GetMedicalFileDto>(fileEntity);
            return resultVO;
        }
        public async override Task<ServiceResponse<bool>> Delete(long id)
        {
            MedicalFile? fileEntity = await _entityRepository.FindByID(id);

            bool result = await _filePersistor.DeleteFile(fileEntity, fileEntity.MedicalId.ToString());
            if (result)
            {
                return new ServiceResponse<bool>() { Success = await _entityRepository.Delete(id) };
            }
            return new ServiceResponse<bool>() { Success = false };
        }
    }
}