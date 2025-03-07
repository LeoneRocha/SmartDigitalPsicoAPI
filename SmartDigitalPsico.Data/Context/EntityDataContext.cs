﻿using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Data.Context.Interface;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context
{
    public abstract class EntityDataContext : DbContext, IEntityDataContext
    {
        protected EntityDataContext()
        {
        }
        protected EntityDataContext(DbContextOptions<SmartDigitalPsicoDataContextMySql> options) : base(options)
        {
        }
        protected EntityDataContext(DbContextOptions<SmartDigitalPsicoDataContextSqlServer> options) : base(options)
        {
        }
        #region DBsets
        public virtual DbSet<ApplicationCacheLog> ApplicationCacheLogs { get; set; }
        public virtual DbSet<ApplicationConfigSetting> ApplicationConfigSettings { get; set; }
        public virtual DbSet<ApplicationLanguage> ApplicationLanguages { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<InfoTag> InfoTags { get; set; }
        public virtual DbSet<Medical> Medicals { get; set; }
        public virtual DbSet<MedicalCalendar> MedicalCalendars { get; set; }
        public virtual DbSet<MedicalFile> MedicalFiles { get; set; }
        public virtual DbSet<MedicalSpecialty> MedicalSpecialties { get; set; }
        public virtual DbSet<NotificationRecord> NotificationRecords { get; set; }
        public virtual DbSet<NotificationRule> NotificationRules { get; set; }
        public virtual DbSet<NotificationTemplate> NotificationTemplates { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientAdditionalInformation> PatientAdditionalInformations { get; set; }
        public virtual DbSet<PatientFile> PatientFiles { get; set; }
        public virtual DbSet<PatientHospitalizationInformation> PatientHospitalizationInformations { get; set; }
        public virtual DbSet<PatientInfoTag> PatientInfoTags { get; set; }
        public virtual DbSet<PatientMedicationInformation> PatientMedicationInformations { get; set; }
        public virtual DbSet<PatientNotificationMessage> PatientNotificationMessages { get; set; }
        public virtual DbSet<PatientRecord> PatientRecords { get; set; }
        public virtual DbSet<RoleGroup> RoleGroups { get; set; }
        public virtual DbSet<RoleGroupUser> RoleGroupUsers { get; set; }
        public virtual DbSet<Specialty> Specialties { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<AuditDataEntityLog> AuditLogs { get; set; }
        public virtual DbSet<AuditDataSelectiveEntityLog> AuditSelectiveLogs { get; set; }
        public virtual DbSet<UserTokenSession> UserTokenSessions { get; set; }
         
        #endregion DBsets  
    }
}