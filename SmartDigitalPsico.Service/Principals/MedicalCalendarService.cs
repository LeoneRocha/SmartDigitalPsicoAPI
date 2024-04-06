using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Domains;
using SmartDigitalPsico.Domain.VO.Medical.MedicalCalendar;
using SmartDigitalPsico.Service.Generic;

namespace SmartDigitalPsico.Service.Principals
{
    public class MedicalCalendarService : EntityBaseService<MedicalCalendar, AddMedicalCalendarVO, UpdateMedicalCalendarVO, GetMedicalCalendarVO, IMedicalCalendarRepository>, IMedicalCalendarService

    {  
        public MedicalCalendarService(IMapper mapper, IMedicalCalendarRepository entityRepository, IMedicalRepository medicalRepository, IConfiguration configuration
            , IUserRepository userRepository
            , IValidator<MedicalCalendar> entityValidator, IApplicationLanguageRepository applicationLanguageRepository, ICacheService cacheService
            , IOptions<LocationSaveFileConfigurationVO> locationSaveFileConfigurationVO)
            : base(mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        { 
        } 
    }
}