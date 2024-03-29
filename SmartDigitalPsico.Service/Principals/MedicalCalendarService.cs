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
        private readonly IMapper _mapper;
        IConfiguration _configuration;
        private readonly IMedicalCalendarRepository _entityRepository;
        private readonly IMedicalRepository _medicalRepository;
        private readonly IUserRepository _userRepository;
        private readonly IFileDiskRepository _repositoryFileDisk;
        private readonly LocationSaveFileConfigurationVO _locationSaveFileConfigurationVO;

        public MedicalCalendarService(IMapper mapper, IMedicalCalendarRepository entityRepository, IMedicalRepository medicalRepository, IConfiguration configuration
            , IUserRepository userRepository
            , IValidator<MedicalCalendar> entityValidator, IApplicationLanguageRepository applicationLanguageRepository, ICacheService cacheService
            , IOptions<LocationSaveFileConfigurationVO> locationSaveFileConfigurationVO)
            : base(mapper, entityRepository, entityValidator, applicationLanguageRepository, cacheService)
        {
            _mapper = mapper;
            _configuration = configuration;
            _entityRepository = entityRepository;
            _medicalRepository = medicalRepository;
            _userRepository = userRepository;
        } 
    }
}