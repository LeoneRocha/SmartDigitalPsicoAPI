using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SmartDigitalPsico.Data.Repository.CacheManager;
using SmartDigitalPsico.Data.Repository.FileManager;
using SmartDigitalPsico.Data.Repository.Principals;
using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Security;
using SmartDigitalPsico.Domain.Validation.PatientValidations;
using SmartDigitalPsico.Domain.Validation.Principals;
using SmartDigitalPsico.Domain.Validation.SystemDomains;
using SmartDigitalPsico.Service.CacheManager;
using SmartDigitalPsico.Service.Principals;
using SmartDigitalPsico.Service.SystemDomains;

namespace SmartDigitalPsico.WebAPI.Helper
{
    public static class DependenciesInjectionConfigure
    {

        public static void AddDependenciesInjection(IServiceCollection Service)
        {
            addRepositories(Service);
            addService(Service);
            addDependencies(Service);
            addValidations(Service);
        }

        #region INTERFACES
        private static void addRepositories(IServiceCollection Service)
        {
            Service.AddScoped<IFileDiskRepository, FileDiskRepository>();
            Service.AddScoped<IMemoryCacheRepository, MemoryCacheRepository>();
            Service.AddScoped<IDiskCacheRepository, DiskCacheRepository>();

            Service.AddScoped<IUserRepository, UserRepository>();
            Service.AddScoped<IMedicalRepository, MedicalRepository>();

            Service.AddScoped<IPatientFileRepository, PatientFileRepository>();
            Service.AddScoped<IMedicalFileRepository, MedicalFileRepository>();

            #region PATIENT
            Service.AddScoped<IPatientRepository, PatientRepository>();
            Service.AddScoped<IPatientRecordRepository, PatientRecordRepository>();
            Service.AddScoped<IPatientMedicationInformationRepository, PatientMedicationInformationRepository>();
            Service.AddScoped<IPatientHospitalizationInformationRepository, PatientHospitalizationInformationRepository>();
            Service.AddScoped<IPatientAdditionalInformationRepository, PatientAdditionalInformationRepository>();
            Service.AddScoped<IPatientNotificationMessageRepository, PatientNotificationMessageRepository>();
            #endregion PATIENT

            Service.AddScoped<IApplicationLanguageRepository, ApplicationLanguageRepository>();
            Service.AddScoped<IApplicationConfigSettingRepository, ApplicationConfigSettingRepository>();
            Service.AddScoped<IApplicationCacheLogRepository, ApplicationCacheLogRepository>();


            Service.AddScoped<IGenderRepository, GenderRepository>();
            Service.AddScoped<IOfficeRepository, OfficeRepository>();
            Service.AddScoped<IRoleGroupRepository, RoleGroupRepository>();
            Service.AddScoped<ISpecialtyRepository, SpecialtyRepository>();

        }


        private static void addService(IServiceCollection Service)
        {
            Service.AddScoped<ICacheService, CacheService>();

            Service.AddScoped<IApplicationLanguageService, ApplicationLanguageService>();
            Service.AddScoped<IApplicationConfigSettingService, ApplicationConfigSettingService>();

            Service.AddScoped<IGenderService, GenderService>();
            Service.AddScoped<IOfficeService, OfficeService>();
            Service.AddScoped<IRoleGroupService, RoleGroupService>();
            Service.AddScoped<ISpecialtyService, SpecialtyService>();

            Service.AddScoped<IUserService, UserService>();
            Service.AddScoped<IMedicalService, MedicalService>();

            Service.AddScoped<IPatientFileService, PatientFileService>();
            Service.AddScoped<IMedicalFileService, MedicalFileService>();
            #region PATIENT
            Service.AddScoped<IPatientService, PatientService>();
            Service.AddScoped<IPatientRecordService, PatientRecordService>();
            Service.AddScoped<IPatientMedicationInformationService, PatientMedicationInformationService>();
            Service.AddScoped<IPatientHospitalizationInformationService, PatientHospitalizationInformationService>();
            Service.AddScoped<IPatientAdditionalInformationService, PatientAdditionalInformationService>();
            Service.AddScoped<IPatientNotificationMessageService, PatientNotificationMessageService>();
            #endregion PATIENT
        }
        private static void addDependencies(IServiceCollection Service)
        {
            Service.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            Service.AddScoped<ITokenConfiguration, TokenConfiguration>();
            Service.AddScoped<ITokenService, TokenService>();
        }
        private static void addValidations(IServiceCollection Service)
        {
            #region SystemDomains
            Service.AddScoped<IValidator<ApplicationConfigSetting>, ApplicationConfigSettingValidator>();
            Service.AddScoped<IValidator<ApplicationLanguage>, ApplicationLanguageValidator>();
            Service.AddScoped<IValidator<Gender>, GenderValidator>();
            Service.AddScoped<IValidator<Office>, OfficeValidator>();
            Service.AddScoped<IValidator<RoleGroup>, RoleGroupValidator>();
            Service.AddScoped<IValidator<Specialty>, SpecialtyValidator>();
            #endregion SystemDomains

            #region Principals
            Service.AddScoped<IValidator<User>, UserValidator>();
            Service.AddScoped<IValidator<Medical>, MedicalValidator>();
            Service.AddScoped<IValidator<MedicalFile>, MedicalFileValidator>();
            #endregion Principals

            #region Patient
            Service.AddScoped<IValidator<PatientAdditionalInformation>, PatientAdditionalInformationValidator>();
            Service.AddScoped<IValidator<PatientHospitalizationInformation>, PatientHospitalizationInformationValidator>();
            Service.AddScoped<IValidator<PatientMedicationInformation>, PatientMedicationInformationValidator>();
            Service.AddScoped<IValidator<PatientNotificationMessage>, PatientNotificationMessageValidator>();
            Service.AddScoped<IValidator<PatientRecord>, PatientRecordValidator>();
            Service.AddScoped<IValidator<PatientFile>, PatientFileValidator>();
            Service.AddScoped<IValidator<Patient>, PatientValidator>();
            #endregion 
        }

        #endregion
    }
}
