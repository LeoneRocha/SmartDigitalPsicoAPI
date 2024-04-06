using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context
{
    public abstract class EntityDataContext : DbContext
    {
        protected EntityDataContext(DbContextOptions<SmartDigitalPsicoDataContext> options) : base(options)
        {
        }

        #region DBsets
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<RoleGroup> RoleGroups { get; set; }
        public virtual DbSet<Specialty> Specialties { get; set; }
        public virtual DbSet<ApplicationLanguage> ApplicationLanguages { get; set; }
        public virtual DbSet<ApplicationConfigSetting> ApplicationConfigSettings { get; set; }
        public virtual DbSet<ApplicationCacheLog> ApplicationCacheLogs { get; set; }
        public virtual DbSet<InfoTag> InfoTags { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Medical> Medicals { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientAdditionalInformation> PatientAdditionalInformations { get; set; }
        public virtual DbSet<PatientHospitalizationInformation> PatientHospitalizationInformations { get; set; }
        public virtual DbSet<PatientMedicationInformation> PatientMedicationInformations { get; set; }
        public virtual DbSet<PatientRecord> PatientRecords { get; set; }
        public virtual DbSet<PatientNotificationMessage> PatientNotificationMessages { get; set; }
        public virtual DbSet<PatientFile> PatientFiles { get; set; }
        public virtual DbSet<MedicalFile> MedicalFiles { get; set; }
        public virtual DbSet<MedicalCalendar> MedicalCalendars { get; set; }
        #endregion DBsets

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            //optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
