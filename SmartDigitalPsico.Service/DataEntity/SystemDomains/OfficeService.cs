using AutoMapper;
using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Domains.AddVOs;
using SmartDigitalPsico.Domain.VO.Domains.GetVOs;
using SmartDigitalPsico.Domain.VO.Domains.UpdateVOs;
using SmartDigitalPsico.Service.DataEntity.Generic;

namespace SmartDigitalPsico.Service.DataEntity.SystemDomains
{
    public class OfficeService : EntityBaseService<Office, AddOfficeVO, UpdateOfficeVO, GetOfficeVO, IOfficeRepository>, IOfficeService

    {
        public OfficeService(IMapper _mapper
            , Serilog.ILogger logger
            , IResiliencePolicyConfig policyConfig
            , IOfficeRepository entityRepository
            , IValidator<Office> entityValidator
            , IApplicationLanguageRepository applicationLanguageRepository
            , ICacheService cacheService)
            : base(_mapper, logger, policyConfig, entityRepository, entityValidator, applicationLanguageRepository, cacheService) { }
    }
}