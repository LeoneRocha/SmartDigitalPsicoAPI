﻿using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SmartDigitalPsico.Data.Audit;
using SmartDigitalPsico.Data.Audit.Interface;
using SmartDigitalPsico.Data.Repository.CacheManager;
using SmartDigitalPsico.Data.Repository.FileManager;
using SmartDigitalPsico.Data.Repository.Principals;
using SmartDigitalPsico.Data.Repository.SystemDomains;
using SmartDigitalPsico.Domain.Constants;
using SmartDigitalPsico.Domain.DependeciesCollection;
using SmartDigitalPsico.Domain.DTO.Domains;
using SmartDigitalPsico.Domain.Interfaces;
using SmartDigitalPsico.Domain.Interfaces.Audit;
using SmartDigitalPsico.Domain.Interfaces.Collection;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure;
using SmartDigitalPsico.Domain.Interfaces.Infrastructure.Report;
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
using SmartDigitalPsico.Service.Audit;
using SmartDigitalPsico.Service.DataEntity.Principals;
using SmartDigitalPsico.Service.DataEntity.SystemDomains;
using SmartDigitalPsico.Service.Infrastructure;
using SmartDigitalPsico.Service.Infrastructure.Authentication;
using SmartDigitalPsico.Service.Infrastructure.Azure.Storage;
using SmartDigitalPsico.Service.Infrastructure.CacheManager;
using SmartDigitalPsico.Service.Infrastructure.Report;
using SmartDigitalPsico.Service.Infrastructure.Smtp;
using SmartDigitalPsico.Service.Report.Entity;
using SmartDigitalPsico.Service.Security;

namespace SmartDigitalPsico.Service.Configure
{
    public static class ApplicationConfigureDependenciesServices
    {
        public static void Configure(IServiceCollection services, IConfiguration _configuration)
        {
            addRepositories(services);
            addService(services);
            addDependenciesSingleton(services);
            addValidations(services);
            addSecurity(services);
            addNoSQLDependencies(services);
            addSmtpDependencies(services);
            addQueueDependencies(services);
            addCollectionDependencies(services);
            addReportDependencies(services);
            addAuditDependencies(services);
            authenticationDependencies(services);
        }
        private static void authenticationDependencies(IServiceCollection services)
        {
            services.AddScoped<IUserTokenSessionRepository, UserTokenSessionRepository>();
            services.AddScoped<ITokenSessionPersistenceFactory, TokenSessionPersistenceFactory>();
            services.AddScoped<ITokenSessionPersistenceService, TokenSessionService>();
        }

        private static void addAuditDependencies(IServiceCollection services)
        {
            services.AddSingleton<IAuditContextService, AuditContextService>();
            services.AddSingleton<IAuditPersistenceServiceFactory, AuditPersistenceServiceFactory>();
            services.AddScoped<AuditPersistenceAzureTableService>();
            services.AddSingleton<AuditPersistenceDataBaseService>();
            services.AddSingleton<AuditPersistenceLogService>();
            services.AddSingleton<AuditContextInterceptor>();

            services.AddScoped<IAuditDataSelectiveEntityLogRepository, AuditDataSelectiveEntityLogRepository>();
            services.AddScoped<IAuditDataSelectiveEntityLogService, AuditDataSelectiveEntityLogService>();
            services.AddScoped<IValidator<AuditDataSelectiveEntityLog>, AuditDataSelectiveEntityLogValidator>();
        }

        private static void addReportDependencies(IServiceCollection services)
        {
            services.AddScoped<IExcelGeneratorService, ExcelGeneratorService>();
            services.AddScoped<IExcelGeneratorFactory, ExcelGeneratorFactory>();

            services.AddScoped<IPdfReportAdapterFactory, PdfReportAdapterFactory>();
            services.AddScoped<IPdfReportService, PdfReportService>();
            #region ENTITIES

            services.AddScoped<IPatientReportService, PatientReportService>();

            #endregion

            services.AddScoped<IReportServiceConfig, ReportServiceConfig>();
        }

        private static void addCollectionDependencies(IServiceCollection services)
        {
            services.AddScoped<IPatientRecordServiceConfig, PatientRecordServiceConfig>();
            services.AddScoped<IPatientRepositories, PatientRepositories>();
            services.AddScoped<ISharedDependenciesConfig, SharedDependenciesConfig>();
            services.AddScoped<ISharedRepositories, SharedRepositories>();
            services.AddScoped<ISharedServices, SharedServices>();
        }

        private static void addSmtpDependencies(IServiceCollection services)
        {
            services.AddSingleton<IEmailService, EmailService>();
            services.AddSingleton<IEmailStrategyFactory, EmailStrategyFactory>();
            services.AddSingleton<EmailContext>();
        }

        private static void addNoSQLDependencies(IServiceCollection services)
        {
            services.AddTransient<IStorageTableRepositoryFactory, StorageTableRepositoryFactory>();

            services.AddScoped<IStorageTableContract<PatientRecordTableEntity>>(provider =>
            {
                var serviceFactory = provider.GetRequiredService<IStorageTableRepositoryFactory>();
                return new StorageTableEntityService<PatientRecordTableEntity>(serviceFactory, StorageTableConstants.PatientRecordTable);
            });

            services.AddScoped<IStorageTableContract<UserTokenSessionTableEntity>>(provider =>
            {
                var serviceFactory = provider.GetRequiredService<IStorageTableRepositoryFactory>();
                return new StorageTableEntityService<UserTokenSessionTableEntity>(serviceFactory, StorageTableConstants.UserTokenSessionTable);
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
        private static void addRepositories(IServiceCollection services)
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

        private static void addService(IServiceCollection services)
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
        }
        private static void addDependenciesSingleton(IServiceCollection services)
        {
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddSingleton<ITokenService, TokenService>();
            services.AddSingleton<IResiliencePolicyConfig, ResiliencePolicyConfig>();
            services.AddSingleton<ILocationSaveFileConfigurationDto, LocationSaveFileConfigurationDto>();
        }
        private static void addValidations(IServiceCollection services)
        {
            #region SystemDomains
            services.AddScoped<IValidator<ApplicationConfigSetting>, ApplicationConfigSettingValidator>();
            services.AddScoped<IValidator<ApplicationLanguage>, ApplicationLanguageValidator>();
            services.AddScoped<IValidator<Gender>, GenderValidator>();
            services.AddScoped<IValidator<Office>, OfficeValidator>();
            services.AddScoped<IValidator<RoleGroup>, RoleGroupValidator>();
            services.AddScoped<IValidator<Specialty>, SpecialtyValidator>();
            services.AddScoped<IValidator<EmailTemplate>, EmailTemplateValidator>();
            #endregion SystemDomains

            #region Principals
            services.AddScoped<IValidator<User>, UserValidator>();
            services.AddScoped<IValidator<Medical>, MedicalValidator>();
            services.AddScoped<IValidator<MedicalFile>, MedicalFileValidator>();
            #endregion Principals

            #region Patient
            services.AddScoped<IValidator<PatientAdditionalInformation>, PatientAdditionalInformationValidator>();
            services.AddScoped<IValidator<PatientHospitalizationInformation>, PatientHospitalizationInformationValidator>();
            services.AddScoped<IValidator<PatientMedicationInformation>, PatientMedicationInformationValidator>();
            services.AddScoped<IValidator<PatientNotificationMessage>, PatientNotificationMessageValidator>();
            services.AddScoped<IValidator<PatientRecord>, PatientRecordValidator>();
            services.AddScoped<IValidator<PatientFile>, PatientFileValidator>();
            services.AddScoped<IValidator<Patient>, PatientValidator>();
            #endregion 
        }
        #endregion
    }
}