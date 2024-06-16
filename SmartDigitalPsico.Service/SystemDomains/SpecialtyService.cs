using AutoMapper;
using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Domains.AddVOs;
using SmartDigitalPsico.Domain.VO.Domains.GetVOs;
using SmartDigitalPsico.Domain.VO.Domains.UpdateVOs;
using SmartDigitalPsico.Service.Generic;

namespace SmartDigitalPsico.Service.SystemDomains
{
    public class SpecialtyService
        : EntityBaseService<Specialty, AddSpecialtyVO, UpdateSpecialtyVO, GetSpecialtyVO, ISpecialtyRepository>, ISpecialtyService
    {
        public SpecialtyService(IMapper _mapper
            , Serilog.ILogger logger
            , IResiliencePolicyConfig policyConfig
            , ISpecialtyRepository entityRepository
            , IValidator<Specialty> entityValidator
            , IApplicationLanguageRepository applicationLanguageRepository
            , ICacheService cacheService)
            : base(_mapper, logger, policyConfig, entityRepository, entityValidator, applicationLanguageRepository, cacheService) { }
    }
}