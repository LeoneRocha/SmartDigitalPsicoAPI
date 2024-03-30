using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SmartDigitalPsico.Data.ConfigureFluentAPI.Entity;
using SmartDigitalPsico.Domain.Enuns;

namespace SmartDigitalPsico.Data.Context
{
    public sealed class SmartDigitalPsicoDataContext : EntityDataContext
    {
        public SmartDigitalPsicoDataContext(DbContextOptions<SmartDigitalPsicoDataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var typeDB = configuration.GetValue<ETypeDataBase>("DataBaseConfigurations:TypeDataBase");

            //Configure FLUENT API 
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

            //OLD   
            //ConfigureDataMock.GenerateMock(modelBuilder, typeDB);
              
            base.OnModelCreating(modelBuilder);
        }
    }
}