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
    public class RoleGroupService : EntityBaseService<RoleGroup, AddRoleGroupVO, UpdateRoleGroupVO, GetRoleGroupVO, IRoleGroupRepository>, IRoleGroupService

    {
        public RoleGroupService(IMapper _mapper
            , Serilog.ILogger logger
            , IResiliencePolicyConfig policyConfig
            , IRoleGroupRepository entityRepository
            , IValidator<RoleGroup> entityValidator
            , IApplicationLanguageRepository applicationLanguageRepository
            , ICacheService cacheService)
            : base(_mapper, logger, policyConfig, entityRepository, entityValidator, applicationLanguageRepository, cacheService) { }
    }
}