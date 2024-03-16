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
    public class RoleGroupService : EntityBaseSimpleService<RoleGroup, AddRoleGroupVO, UpdateRoleGroupVO, GetRoleGroupVO, IRoleGroupRepository>, IRoleGroupService

    {
        public RoleGroupService(IMapper _mapper, IRoleGroupRepository entityRepository
            , IValidator<RoleGroup> entityValidator, IApplicationLanguageRepository applicationLanguageRepository, ICacheService cacheService)
            : base(_mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService) { }
    }
}