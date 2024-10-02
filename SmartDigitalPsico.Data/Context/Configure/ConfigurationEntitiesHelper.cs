using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Configure.Entity;
using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Data.Context.Configure
{
    public static class ConfigurationEntitiesHelper
    {
        public static void AddConfigurationEntities(ModelBuilder modelBuilder,  ETypeDataBase eDataBaseType)
        {
            modelBuilder.ApplyConfiguration(new ApplicationCacheLogConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new ApplicationConfigSettingConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new ApplicationLanguageConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new GenderConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new InfoTagConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new MedicalCalendarConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new MedicalConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new MedicalFileConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new OfficeConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new PatientAdditionalInformationConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new PatientConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new PatientFileConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new PatientHospitalizationInformationConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new PatientInfoTagConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new PatientMedicationInformationConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new PatientNotificationMessageConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new PatientRecordConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new RoleGroupConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new SpecialtyConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new UserConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new MedicalSpecialtyConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new RoleGroupUserConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new AuditDataEntityLogConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new AuditDataSelectiveEntityLogConfiguration(eDataBaseType));
            modelBuilder.ApplyConfiguration(new EmailTemplateConfiguration(eDataBaseType));
        } 
    }
} 