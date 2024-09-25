using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Audit;
using SmartDigitalPsico.Data.ConfigureFluentAPI.Entity;
using SmartDigitalPsico.Data.ConfigureFluentAPI.Mock;

namespace SmartDigitalPsico.Data.Context
{
    public class SmartDigitalPsicoDataContext : EntityDataContext
    {
        private readonly AuditInterceptor? _auditInterceptor;
        public SmartDigitalPsicoDataContext()
        { 
        }
        public SmartDigitalPsicoDataContext(DbContextOptions<SmartDigitalPsicoDataContext> options) : base(options)
        {
        }
        //public SmartDigitalPsicoDataContext(DbContextOptions<SmartDigitalPsicoDataContext> options, AuditInterceptor auditInterceptor)
        //    : base(options)
        //{
        //    _auditInterceptor = auditInterceptor;
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure FLUENT API 
            addConfigurationEntities(modelBuilder);

            addDataMock(modelBuilder);
             
            base.OnModelCreating(modelBuilder);
        }

        private static void addConfigurationEntities(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApplicationCacheLogConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationConfigSettingConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationLanguageConfiguration());
            modelBuilder.ApplyConfiguration(new GenderConfiguration());
            modelBuilder.ApplyConfiguration(new InfoTagConfiguration());
            modelBuilder.ApplyConfiguration(new MedicalCalendarConfiguration());
            modelBuilder.ApplyConfiguration(new MedicalConfiguration());
            modelBuilder.ApplyConfiguration(new MedicalFileConfiguration());
            modelBuilder.ApplyConfiguration(new OfficeConfiguration());
            modelBuilder.ApplyConfiguration(new PatientAdditionalInformationConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new PatientFileConfiguration());
            modelBuilder.ApplyConfiguration(new PatientHospitalizationInformationConfiguration());
            modelBuilder.ApplyConfiguration(new PatientInfoTagConfiguration());
            modelBuilder.ApplyConfiguration(new PatientMedicationInformationConfiguration());
            modelBuilder.ApplyConfiguration(new PatientNotificationMessageConfiguration());
            modelBuilder.ApplyConfiguration(new PatientRecordConfiguration());
            modelBuilder.ApplyConfiguration(new RoleGroupConfiguration());
            modelBuilder.ApplyConfiguration(new SpecialtyConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new MedicalSpecialtyConfiguration());
            modelBuilder.ApplyConfiguration(new RoleGroupUserConfiguration());
            modelBuilder.ApplyConfiguration(new AuditDataEntityLogConfiguration());
        }

        private static void addDataMock(ModelBuilder modelBuilder)
        {
            //MOCK DATA
            modelBuilder.ApplyConfiguration(new ApplicationConfigSettingMockData());
            modelBuilder.ApplyConfiguration(new ApplicationLanguageMockData());
            modelBuilder.ApplyConfiguration(new GenderMockData());
            modelBuilder.ApplyConfiguration(new MedicalMockData());
            modelBuilder.ApplyConfiguration(new OfficeMockData());
            modelBuilder.ApplyConfiguration(new PatientMockData());
            modelBuilder.ApplyConfiguration(new RoleGroupMockData());
            modelBuilder.ApplyConfiguration(new SpecialtyMockData());
            modelBuilder.ApplyConfiguration(new UserMockData());
            modelBuilder.ApplyConfiguration(new RoleGroupUserMockData());
            modelBuilder.ApplyConfiguration(new MedicalSpecialtyMockData());
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (_auditInterceptor != null)
        //    {
        //        optionsBuilder.AddInterceptors(_auditInterceptor);
        //    }
        //}
    }
}