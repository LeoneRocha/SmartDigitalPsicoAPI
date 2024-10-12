using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.Validation.PatientValidations;
using SmartDigitalPsico.Domain.Validation.Principals;
using SmartDigitalPsico.Domain.Validation.SystemDomains;

namespace SmartDigitalPsico.Service.Configure.Domain
{
    public static class ServicesDomainValidation
    {
        public static void AddDependencies(IServiceCollection services)
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
            services.AddScoped<IValidator<MedicalCalendar>, MedicalCalendarValidator>();

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
    }
}
