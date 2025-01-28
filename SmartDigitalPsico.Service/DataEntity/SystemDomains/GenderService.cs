using AutoMapper;
using FluentValidation;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Service.DataEntity.Generic;
using SmartDigitalPsico.Domain.VO;

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    public class GenderService : EntityBaseService<Gender, AddGenderDto, UpdateGenderDto, GetGenderDto, IGenderRepository>, IGenderService
    {
        public GenderService(
            ISharedServices sharedServices,
            ISharedDependenciesConfig sharedDependenciesConfig,
            ISharedRepositories sharedRepositories,
            IGenderRepository entityRepository,
            IValidator<Gender> entityValidator
            )
            : base(sharedServices, sharedDependenciesConfig, sharedRepositories, entityRepository, entityValidator)
        {
        }

        public override async Task<ServiceResponse<List<GetGenderDto>>> FindAll()
        {
            string keyCache = "FindAll_GetGenderVO";

            ServiceResponse<List<GetGenderDto>> result = new ServiceResponse<List<GetGenderDto>>();

            if (_cacheService.IsEnable())
            {
                bool existsCache = _cacheService.TryGet(keyCache, out ServiceResponseCacheVO<List<GetGenderDto>> cachedResult);
                if (!existsCache)
                {
                    result = await base.FindAll();
                    ServiceResponseCacheVO<List<GetGenderDto>> cacheSave = new ServiceResponseCacheVO<List<GetGenderDto>>(result, keyCache, _cacheService.GetSlidingExpiration());

                    result.Success = _cacheService.Set(keyCache, cacheSave);
                }
                else
                {
                    result.Data = cachedResult.Data;
                }
            }
            else
            {
                result = await base.FindAll();
            }

            return result;
        }
        public override async Task<ServiceResponse<GetGenderDto>> FindByID(long id)
        {
            ServiceResponse<GetGenderDto> response = new ServiceResponse<GetGenderDto>();

            Gender entityResponse = await _entityRepository.FindByID(id);

            if (entityResponse != null)
            {
                response.Data = _mapper.Map<GetGenderDto>(entityResponse);
                response.Success = true;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                    ("RegisterIsFound", _applicationLanguageRepository, _cacheService);
            }
            else
            {
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                   ("RegisterIsNotFound", _applicationLanguageRepository, _cacheService);
            }
            return response;
        }

        public override async Task<ServiceResponse<GetGenderDto>> Update(UpdateGenderDto item)
        {
            ServiceResponse<GetGenderDto> response = new ServiceResponse<GetGenderDto>();

            bool entityExists = await _entityRepository.Exists(item.Id);

            if (!entityExists)
            {
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsNotFound", _applicationLanguageRepository, _cacheService);
                return response;
            }
            Gender entityUpdate = await _entityRepository.FindByID(item.Id);
            entityUpdate.Description = item.Description;
            entityUpdate.Enable = item.Enable;
            entityUpdate.Language = item.Language;

            response = await Validate(entityUpdate);
            entityUpdate.ModifyDate = DataHelper.GetDateTimeNowFromUtc();
            if (response.Success)
            {
                Gender entityResponse = await _entityRepository.Update(entityUpdate);

                response.Data = _mapper.Map<GetGenderDto>(entityResponse);
                response.Success = true;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                           ("RegisterUpdated", _applicationLanguageRepository, _cacheService);
            }
            return response;
        }
    }
}