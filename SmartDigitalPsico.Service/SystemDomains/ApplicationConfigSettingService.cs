using AutoMapper;
using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Domains.AddVOs;
using SmartDigitalPsico.Domain.VO.Domains.GetVOs;
using SmartDigitalPsico.Domain.VO.Domains.UpdateVOs;
using SmartDigitalPsico.Service.Generic;

namespace SmartDigitalPsico.Service.SystemDomains
{
    public class ApplicationConfigSettingService
      : EntityBaseSimpleService<ApplicationConfigSetting, AddApplicationConfigSettingVO, UpdateApplicationConfigSettingVO, GetApplicationConfigSettingVO, IApplicationConfigSettingRepository>, IApplicationConfigSettingService
    {
        private readonly IMapper _mapper;
        private readonly IApplicationConfigSettingRepository _genericRepository;

        public ApplicationConfigSettingService(IMapper mapper,
            IApplicationConfigSettingRepository entityRepository
            , IValidator<ApplicationConfigSetting> entityValidator
            , IApplicationLanguageRepository applicationLanguageRepository
            , ICacheService cacheService)
            : base(mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {

            _mapper = mapper;
            _genericRepository = entityRepository;
        }
    }
}