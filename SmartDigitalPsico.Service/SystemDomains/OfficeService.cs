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
    public class OfficeService : EntityBaseSimpleService<Office, AddOfficeVO, UpdateOfficeVO, GetOfficeVO, IOfficeRepository>, IOfficeService

    {
        public OfficeService(IMapper _mapper, IOfficeRepository entityRepository, IValidator<Office> entityValidator, IApplicationLanguageRepository applicationLanguageRepository, ICacheService cacheService)
            : base(_mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService) { }
    }
}