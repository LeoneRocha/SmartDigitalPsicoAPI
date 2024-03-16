using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.Hypermedia.Utils;
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
      : EntityBaseSimpleService<Gender, AddGenderVO, UpdateGenderVO, GetGenderVO, IGenderRepository>, IGenderService
    {
        private readonly IMapper _mapper;
        private readonly IGenderRepository _entityRepository;
        private readonly ICacheService _cacheService;
        AuthConfigurationVO _configurationAuth;
        private readonly IStringLocalizer<SharedResource> _localizer;
        public GenderService(IMapper mapper, IGenderRepository entityRepository, ICacheService cacheService,
            IOptions<AuthConfigurationVO> configurationAuth,
            IValidator<Gender> entityValidator
            , IApplicationLanguageRepository applicationLanguageRepository
            , ICacheService cacheBusines)
            : base(mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _mapper = mapper;
            _entityRepository = entityRepository;
            _cacheService = cacheService;
            _configurationAuth = configurationAuth.Value; 
        }

        public override async Task<ServiceResponse<List<GetGenderVO>>> FindAll()
        {
            string keyCache = "FindAll_GetGenderVO";

            ServiceResponse<List<GetGenderVO>> result = new ServiceResponse<List<GetGenderVO>>();
            List<GetGenderVO> listEntity = new List<GetGenderVO>();

            long idu = this.UserId;

            if (_cacheService.IsEnable())
            {
                bool existsCache = _cacheService.TryGet<ServiceResponseCacheVO<List<GetGenderVO>>>(keyCache, out ServiceResponseCacheVO<List<GetGenderVO>> cachedResult);
                if (!existsCache)
                {
                    result = await base.FindAll();
                    ServiceResponseCacheVO<List<GetGenderVO>> cacheSave = new ServiceResponseCacheVO<List<GetGenderVO>>(result, keyCache, _cacheService.GetSlidingExpiration());

                    bool resultAction = _cacheService.Set<ServiceResponseCacheVO<List<GetGenderVO>>>(keyCache, cacheSave);
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
            try
            {
                Gender entityResponse = await _entityRepository.FindByID(id);

                if (entityResponse != null)
                {
                    response.Data = _mapper.Map<GetGenderVO>(entityResponse);
                    response.Success = true;
                    response.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                        ("RegisterIsFound", base._applicationLanguageRepository,base._cacheService);  
                }
                else
                {
                    response.Success = false;
                    response.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                       ("RegisterIsNotFound", base._applicationLanguageRepository, base._cacheService); 
                }
            }
            catch (Exception ex)
            {
                throw ex;
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
                response.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                       ("RegisterIsNotFound", base._applicationLanguageRepository, base._cacheService);
                return response;
            }   
            Gender entityUpdate = await _entityRepository.FindByID(item.Id);
            entityUpdate.Description = item.Description;
            entityUpdate.Enable = item.Enable;
            entityUpdate.Language = item.Language;            

            response = await Validate(entityUpdate);
            entityUpdate.ModifyDate = DateTime.Now;
            if (response.Success)
            {
                Gender entityResponse = await _entityRepository.Update(entityUpdate);

                response.Data = _mapper.Map<GetGenderVO>(entityResponse);
                response.Success = true;
                response.Message = await ApplicationLanguageService.GetLocalization<SharedResource>
                           ("RegisterUpdated", base._applicationLanguageRepository, base._cacheService);
            } 
            return response;

        }
    }
}