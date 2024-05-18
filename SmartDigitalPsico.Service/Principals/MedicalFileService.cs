using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Medical.MedicalFile;
using SmartDigitalPsico.Service.Generic;
using SmartDigitalPsico.Service.SystemDomains;

namespace SmartDigitalPsico.Service.Principals
{
    public class MedicalFileService : EntityBaseService<MedicalFile, AddMedicalFileVO, UpdateMedicalFileVO, GetMedicalFileVO, IMedicalFileRepository>, IMedicalFileService
    {
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly IMedicalFileRepository _entityRepository; 
        private readonly IFilePersistor _filePersistor;
        public MedicalFileService(IMapper mapper
            , IConfiguration configuration
            , IMedicalFileRepository entityRepository
            , IValidator<MedicalFile> entityValidator 
            , ICacheService cacheService
            , IApplicationLanguageRepository applicationLanguageRepository
            , IFilePersistor filePersistor
            )
            : base(mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _mapper = mapper;
            _configuration = configuration;
            _entityRepository = entityRepository; 
            _filePersistor = filePersistor;
        }
        public override async Task<ServiceResponse<List<GetMedicalFileVO>>> FindAll()
        {
            var result = new ServiceResponse<List<GetMedicalFileVO>>();
            result.Success = false;
            result.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>("RegisterIsNotFound", base._applicationLanguageRepository, base._cacheService);

            return result;
        }

        public async override Task<ServiceResponse<GetMedicalFileVO>> FindByID(long id)
        {
            ServiceResponse<GetMedicalFileVO> response = await base.FindByID(id);

            if (response.Data != null && string.IsNullOrEmpty(response.Data.FilePath))
            {
                await FileHelper.GetFromByteSaveTemp(response.Data.FileData, response.Data.FileName, _configuration);
                response.Data.FileUrl = FileHelper.GetFilePath(DirectoryHelper.GetDiretoryTemp(_configuration), response.Data.FileName ?? string.Empty);
            }
            return response;
        }


        public async Task<ServiceResponse<List<GetMedicalFileVO>>> FindAllByMedical(long medicalId)
        {
            ServiceResponse<List<GetMedicalFileVO>> response = new ServiceResponse<List<GetMedicalFileVO>>();

            var listResult = await _entityRepository.FindAllByMedical(medicalId);

            response.Data = listResult.Select(c => _mapper.Map<GetMedicalFileVO>(c)).ToList();
            response.Success = true;
            response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsFound", base._applicationLanguageRepository, base._cacheService);
            return response;
        }

        public override Task<ServiceResponse<GetMedicalFileVO>> Update(UpdateMedicalFileVO item)
        {
            throw new NotImplementedException("Not Permission");
        }

        public async Task<bool> PostFileAsync(AddMedicalFileVO entity)
        {
            ServiceResponse<GetMedicalFileVO> response = new ServiceResponse<GetMedicalFileVO>();

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

                entityAdd.CreatedUserId = this.UserId;
                response.Success = true;
                if (response.Success)
                {
                    entityAdd.FilePath = await _filePersistor.PersistFile(fileData, entityAdd, entity.MedicalId.ToString());
                    MedicalFile entityResponse = await _entityRepository.Create(entityAdd);
                    if (response.Data != null)
                        response.Data.Id = entityResponse.Id;
                }
            }

            return response.Success;
        }

        public async Task<GetMedicalFileVO> DownloadFileById(long fileId)
        {
            MedicalFile? fileEntity = await _entityRepository.FindByID(fileId);

            var resultData = await _filePersistor.DownloadFileById(fileEntity) as MedicalFile;
            if (resultData != null)
            {
                fileEntity.FileData = resultData.FileData;
            }
            GetMedicalFileVO resultVO = _mapper.Map<GetMedicalFileVO>(fileEntity);
            return resultVO;
        }
    }
}