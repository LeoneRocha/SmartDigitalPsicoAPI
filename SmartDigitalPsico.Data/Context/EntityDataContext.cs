﻿using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context
{
    public abstract class EntityDataContext : DbContext

    {
        protected EntityDataContext(DbContextOptions<SmartDigitalPsicoDataContext> options) : base(options)
        {

        }

        #region Statics 
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<RoleGroup> RoleGroups { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<ApplicationLanguage> ApplicationLanguages { get; set; }
        public DbSet<ApplicationConfigSetting> ApplicationConfigSettings { get; set; }

        public DbSet<ApplicationCacheLog> ApplicationCacheLogs { get; set; }

        public DbSet<InfoTag> InfoTags { get; set; }

        #endregion

        #region Principais

        public DbSet<User> Users { get; set; }

        public DbSet<Medical> Medicals { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<PatientAdditionalInformation> PatientAdditionalInformations { get; set; }

        public DbSet<PatientHospitalizationInformation> PatientHospitalizationInformations { get; set; }

        public DbSet<PatientMedicationInformation> PatientMedicationInformations { get; set; }
        public DbSet<PatientRecord> PatientRecords { get; set; }

        public DbSet<PatientNotificationMessage> PatientNotificationMessages { get; set; }

        public DbSet<PatientFile> PatientFiles { get; set; }

        public DbSet<MedicalFile> MedicalFiles { get; set; }

        public DbSet<MedicalCalendar> MedicalCalendars { get; set; }

        #endregion Principais

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            base.OnConfiguring(optionsBuilder);
        }

    }
}
