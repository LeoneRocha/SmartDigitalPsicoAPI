using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Service.DataEntity.Principals;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;
using SmartDigitalPsico.Service.Infrastructure.CacheManager;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    public static class ServicesDomainService
    {
        public static void AddDependencies(IServiceCollection services)
        { 
            services.AddScoped<ICacheService, CacheService>();

            services.AddScoped<IApplicationLanguageService, ApplicationLanguageService>();
            services.AddScoped<IApplicationConfigSettingService, ApplicationConfigSettingService>();

            services.AddScoped<IGenderService, GenderService>();
            services.AddScoped<IOfficeService, OfficeService>();
            services.AddScoped<IRoleGroupService, RoleGroupService>();
            services.AddScoped<ISpecialtyService, SpecialtyService>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IMedicalService, MedicalService>();

            services.AddScoped<IPatientFileService, PatientFileService>();
            services.AddScoped<IMedicalFileService, MedicalFileService>();
            #region PATIENT
            services.AddScoped<IPatientService, PatientService>();
            services.AddScoped<IPatientRecordService, PatientRecordService>();
            services.AddScoped<IPatientMedicationInformationService, PatientMedicationInformationService>();
            services.AddScoped<IPatientHospitalizationInformationService, PatientHospitalizationInformationService>();
            services.AddScoped<IPatientAdditionalInformationService, PatientAdditionalInformationService>();
            services.AddScoped<IPatientNotificationMessageService, PatientNotificationMessageService>();
            #endregion PATIENT   

            services.AddScoped<IEmailTemplateService, EmailTemplateService>();

            services.AddScoped<IMedicalCalendarService, MedicalCalendarService>();
        }
    }
}