using AutoMapper;
using FluentValidation;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Domains;
using SmartDigitalPsico.Domain.VO.Domains.AddVOs;
using SmartDigitalPsico.Domain.VO.Domains.GetVOs;
using SmartDigitalPsico.Domain.VO.Domains.UpdateVOs;
using SmartDigitalPsico.Service.Generic;

namespace SmartDigitalPsico.Service.SystemDomains
{
    public class GenderService
      : EntityBaseService<Gender, AddGenderVO, UpdateGenderVO, GetGenderVO, IGenderRepository>, IGenderService
    {
        private readonly IMapper _mapper;
        private readonly IGenderRepository _entityRepository; 
        public GenderService(IMapper mapper, IGenderRepository entityRepository, ICacheService cacheService,            
            IValidator<Gender> entityValidator
            , IApplicationLanguageRepository applicationLanguageRepository)
            : base(mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _mapper = mapper;
            _entityRepository = entityRepository; 
        }

        public override async Task<ServiceResponse<List<GetGenderVO>>> FindAll()
        {
            string keyCache = "FindAll_GetGenderVO";

            ServiceResponse<List<GetGenderVO>> result = new ServiceResponse<List<GetGenderVO>>();

            if (_cacheService.IsEnable())
            {
                bool existsCache = _cacheService.TryGet(keyCache, out ServiceResponseCacheVO<List<GetGenderVO>> cachedResult);
                if (!existsCache)
                {
                    result = await base.FindAll();
                    ServiceResponseCacheVO<List<GetGenderVO>> cacheSave = new ServiceResponseCacheVO<List<GetGenderVO>>(result, keyCache, _cacheService.GetSlidingExpiration());

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
        public override async Task<ServiceResponse<GetGenderVO>> FindByID(long id)
        {
            ServiceResponse<GetGenderVO> response = new ServiceResponse<GetGenderVO>();

            Gender entityResponse = await _entityRepository.FindByID(id);

            if (entityResponse != null)
            {
                response.Data = _mapper.Map<GetGenderVO>(entityResponse);
                response.Success = true;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                    ("RegisterIsFound", base._applicationLanguageRepository, base._cacheService);
            }
            else
            {
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                   ("RegisterIsNotFound", base._applicationLanguageRepository, base._cacheService);
            }
            return response;
        }

        public override async Task<ServiceResponse<GetGenderVO>> Update(UpdateGenderVO item)
        {
            ServiceResponse<GetGenderVO> response = new ServiceResponse<GetGenderVO>();

            bool entityExists = await _entityRepository.Exists(item.Id);

            if (!entityExists)
            {
                response.Success = false;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                       ("RegisterIsNotFound", base._applicationLanguageRepository, base._cacheService);
                return response;
            }
            Gender entityUpdate = await _entityRepository.FindByID(item.Id);
            entityUpdate.Description = item.Description;
            entityUpdate.Enable = item.Enable;
            entityUpdate.Language = item.Language;

            response = await Validate(entityUpdate);
            entityUpdate.ModifyDate = DataHelper.GetDateTimeNow();
            if (response.Success)
            {
                Gender entityResponse = await _entityRepository.Update(entityUpdate);

                response.Data = _mapper.Map<GetGenderVO>(entityResponse);
                response.Success = true;
                response.Message = await ApplicationLanguageService.GetLocalization<ISharedResource>
                           ("RegisterUpdated", base._applicationLanguageRepository, base._cacheService);
            }
            return response;
        }
    }
}