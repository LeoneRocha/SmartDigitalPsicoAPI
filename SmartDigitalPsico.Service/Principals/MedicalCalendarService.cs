using AutoMapper;
using FluentValidation;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Medical.MedicalCalendar;
using SmartDigitalPsico.Service.Generic;

namespace SmartDigitalPsico.Service.Principals
{
    public class MedicalCalendarService : EntityBaseService<MedicalCalendar, AddMedicalCalendarVO, UpdateMedicalCalendarVO, GetMedicalCalendarVO, IMedicalCalendarRepository>, IMedicalCalendarService

    {
        public MedicalCalendarService(IMapper mapper
            , Serilog.ILogger logger
            , IResiliencePolicyConfig policyConfig
            , IMedicalCalendarRepository entityRepository
            , IValidator<MedicalCalendar> entityValidator
            , IApplicationLanguageRepository applicationLanguageRepository
            , ICacheService cacheService)
            : base(mapper, logger, policyConfig, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
        }
    }
}