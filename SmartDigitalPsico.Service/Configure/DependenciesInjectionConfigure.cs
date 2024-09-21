using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using SmartDigitalPsico.Data.Repository.CacheManager;
using SmartDigitalPsico.Data.Repository.FileManager;
using SmartDigitalPsico.Data.Repository.Principals;
using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.DependeciesCollection;
using SmartDigitalPsico.Domain.Helpers;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
using SmartDigitalPsico.Domain.Interfaces.Report;
using SmartDigitalPsico.Domain.Interfaces.Repository;
using SmartDigitalPsico.Domain.Interfaces.Security;
using SmartDigitalPsico.Domain.Interfaces.Service;
using SmartDigitalPsico.Domain.Interfaces.Smtp;
using SmartDigitalPsico.Domain.Interfaces.TableEntity;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Resiliency;
using SmartDigitalPsico.Domain.Security;
using SmartDigitalPsico.Domain.TableEntityNoSQL;
using SmartDigitalPsico.Domain.Validation.PatientValidations;
using SmartDigitalPsico.Domain.Validation.Principals;
using SmartDigitalPsico.Domain.Validation.SystemDomains;
using SmartDigitalPsico.Domain.VO.Domains;
using SmartDigitalPsico.Domain.VO.Security;
using SmartDigitalPsico.Domain.VO.SMTP;
using SmartDigitalPsico.Service.DataEntity.Principals;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;
using SmartDigitalPsico.Service.Infrastructure;
using SmartDigitalPsico.Service.Infrastructure.Azure.Storage;
using SmartDigitalPsico.Service.Infrastructure.CacheManager;
using SmartDigitalPsico.Service.Infrastructure.Report;
using SmartDigitalPsico.Service.Infrastructure.Smtp;
using SmartDigitalPsico.Service.Report.Entity;
using SmartDigitalPsico.Service.Security;

namespace SmartDigitalPsico.Service.Configure
{
    public static class DependenciesInjectionConfigure
    {
        public static void AddDependenciesInjection(IServiceCollection services, IConfiguration _configuration)
        {
            addRepositories(services);
            addService(services);
            addDependenciesSingleton(services);
            addValidations(services);
            addSecurity(services);
            addNoSQLDependencies(services);
            addSmtpDependencies(services, _configuration);
            addQueueDependencies(services);
            addCollectionDependencies(services);
            addReportDependencies(services);
        }

        private static void addReportDependencies(IServiceCollection services)
        {
            services.AddScoped<IExcelGeneratorService, ExcelGeneratorService>();
            services.AddScoped<IExcelGeneratorFactory, ExcelGeneratorFactory>();
        }

        private static void addCollectionDependencies(IServiceCollection services)
        {
            services.AddScoped<IPatientRecordServiceConfig, PatientRecordServiceConfig>();
            services.AddScoped<IPatientRepositories, PatientRepositories>();
            services.AddScoped<ISharedDependenciesConfig, SharedDependenciesConfig>();
            services.AddScoped<ISharedRepositories, SharedRepositories>();
            services.AddScoped<ISharedServices, SharedServices>();
        }

        private static void addSmtpDependencies(IServiceCollection services, IConfiguration _configuration)
        {
            services.AddSingleton<IEmailService, EmailService>();
            services.AddSingleton<IEmailStrategyFactory, EmailStrategyFactory>();
            services.AddSingleton<EmailContext>();

            // Bind the PolicyConfig section of appsettings.json to the PolicyConfig class
            var smtpSettings = new SmtpSettingsVO();

            var configValue = ConfigurationAppSettingsHelper.GetSmtpSettings(_configuration);
            new ConfigureFromConfigurationOptions<SmtpSettingsVO>(configValue)
             .Configure(smtpSettings);
            // Register the PolicyConfig instance as a singleton
            services.AddSingleton<ISmtpSettingsVO>(smtpSettings);
        }

        private static void addNoSQLDependencies(IServiceCollection services)
        {
            services.AddTransient<IStorageTableRepositoryFactory, StorageTableRepositoryFactory>();

            services.AddScoped<IStorageTableContract<PatientRecordTableEntity>>(provider =>
            {
                var serviceFactory = provider.GetRequiredService<IStorageTableRepositoryFactory>();
                return new StorageTableEntityService<PatientRecordTableEntity>(serviceFactory, StorageTableConstants.PatientRecordTable);
            });
        }

        private static void addQueueDependencies(IServiceCollection services)
        {
            services.AddTransient<IStorageQueueRepositoryFactory, StorageQueueRepositoryFactory>();
            services.AddScoped<IStorageQueueContract>(provider =>
            {
                var serviceFactory = provider.GetRequiredService<IStorageQueueRepositoryFactory>();
                return new StorageQueueService(serviceFactory, StorageQueueNameConstants.GeneralQueue);
            });
        }

        private static void addSecurity(IServiceCollection services)
        {
            services.AddTransient<ICryptoAdapterFactory, CryptoAdapterFactory>();
            services.AddTransient<ICryptoService, CryptoService>();
        }

        #region INTERFACES
        private static void addRepositories(IServiceCollection Service)
        {
            Service.AddScoped<IFileManager, FileManager>();
            Service.AddScoped<IFileDiskRepository, FileDiskRepository>();
            Service.AddScoped<IMemoryCacheRepository, MemoryCacheRepository>();
            Service.AddScoped<IDiskCacheRepository, DiskCacheRepository>();
            Service.AddScoped<IStorageBlobAdapter, AzureStorageBlobAdapter>();

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


        private static void addService(IServiceCollection service)
        {
            service.AddScoped<ICacheService, CacheService>();

            service.AddScoped<IApplicationLanguageService, ApplicationLanguageService>();
            service.AddScoped<IApplicationConfigSettingService, ApplicationConfigSettingService>();

            service.AddScoped<IGenderService, GenderService>();
            service.AddScoped<IOfficeService, OfficeService>();
            service.AddScoped<IRoleGroupService, RoleGroupService>();
            service.AddScoped<ISpecialtyService, SpecialtyService>();

            service.AddScoped<IUserService, UserService>();
            service.AddScoped<IMedicalService, MedicalService>();

            service.AddScoped<IPatientFileService, PatientFileService>();
            service.AddScoped<IMedicalFileService, MedicalFileService>();
            #region PATIENT
            service.AddScoped<IPatientService, PatientService>();
            service.AddScoped<IPatientRecordService, PatientRecordService>();
            service.AddScoped<IPatientMedicationInformationService, PatientMedicationInformationService>();
            service.AddScoped<IPatientHospitalizationInformationService, PatientHospitalizationInformationService>();
            service.AddScoped<IPatientAdditionalInformationService, PatientAdditionalInformationService>();
            service.AddScoped<IPatientNotificationMessageService, PatientNotificationMessageService>();
            #endregion PATIENT  
             
            service.AddScoped<IPatientReportService, PatientReportService>();
        }
        private static void addDependenciesSingleton(IServiceCollection Service)
        {
            Service.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            Service.AddSingleton<ITokenConfigurationVO, TokenConfigurationVO>();
            Service.AddSingleton<ITokenService, TokenService>();
            Service.AddSingleton<IResiliencePolicyConfig, ResiliencePolicyConfig>();
            Service.AddSingleton<ILocationSaveFileConfigurationVO, LocationSaveFileConfigurationVO>();
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
