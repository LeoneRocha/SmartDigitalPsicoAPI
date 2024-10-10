using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Data.Repository.CacheManager;
using SmartDigitalPsico.Data.Repository.FileManager;
using SmartDigitalPsico.Data.Repository.Principals;
using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Service.Infrastructure.Azure.Storage;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    public static class ServicesDomainRepository
    {
        public static void AddDependencies(IServiceCollection services)
        {
            services.AddSingleton<IMemoryCacheRepository, MemoryCacheRepository>();
            services.AddScoped<IFileManager, FileManager>();
            services.AddScoped<IFileDiskRepository, FileDiskRepository>();
            services.AddScoped<IDiskCacheRepository, DiskCacheRepository>();
            services.AddScoped<IStorageBlobAdapter, AzureStorageBlobAdapter>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IMedicalRepository, MedicalRepository>();
            services.AddScoped<IPatientFileRepository, PatientFileRepository>();
            services.AddScoped<IMedicalFileRepository, MedicalFileRepository>();
            #region PATIENT
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<IPatientRecordRepository, PatientRecordRepository>();
            services.AddScoped<IPatientMedicationInformationRepository, PatientMedicationInformationRepository>();
            services.AddScoped<IPatientHospitalizationInformationRepository, PatientHospitalizationInformationRepository>();
            services.AddScoped<IPatientAdditionalInformationRepository, PatientAdditionalInformationRepository>();
            services.AddScoped<IPatientNotificationMessageRepository, PatientNotificationMessageRepository>();
            #endregion PATIENT
            services.AddScoped<IApplicationLanguageRepository, ApplicationLanguageRepository>();
            services.AddScoped<IApplicationConfigSettingRepository, ApplicationConfigSettingRepository>();
            services.AddScoped<IApplicationCacheLogRepository, ApplicationCacheLogRepository>();
            services.AddScoped<IGenderRepository, GenderRepository>();
            services.AddScoped<IOfficeRepository, OfficeRepository>();
            services.AddScoped<IRoleGroupRepository, RoleGroupRepository>();
            services.AddScoped<ISpecialtyRepository, SpecialtyRepository>();
            services.AddScoped<IAuditDataSelectiveEntityLogRepository, AuditDataSelectiveEntityLogRepository>();
            services.AddScoped<IEmailTemplateRepository, EmailTemplateRepository>();
        }
    }
}