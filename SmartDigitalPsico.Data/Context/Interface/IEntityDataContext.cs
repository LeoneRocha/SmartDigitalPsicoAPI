using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.ModelEntity.Schedule;

namespace SmartDigitalPsico.Data.Context.Interface
{
    /// <summary>
    /// Shim Obsolete — contrato genérico em SmartDigitalPsico.Core.SDK; DbSets de produto permanecem aqui.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — parte genérica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use SmartDigitalPsico.Core.SDK.Data.Context.Interface.IEntityDataContext para o contrato genérico. DbSets de produto permanecem neste shim.", error: false, DiagnosticId = "SDP_CORE_SDK_REPO")]
    public interface IEntityDataContext : SmartDigitalPsico.Core.SDK.Data.Context.Interface.IEntityDataContext
    {
        DbSet<ApplicationCacheLog> ApplicationCacheLogs { get; set; }
        DbSet<ApplicationConfigSetting> ApplicationConfigSettings { get; set; }
        DbSet<ApplicationLanguage> ApplicationLanguages { get; set; }
        DbSet<AuditDataEntityLog> AuditLogs { get; set; }
        DbSet<AuditDataSelectiveEntityLog> AuditSelectiveLogs { get; set; }
        DbSet<Gender> Genders { get; set; }
        DbSet<InfoTag> InfoTags { get; set; }
        DbSet<MedicalFile> MedicalFiles { get; set; }
        DbSet<Medical> Medicals { get; set; }
        DbSet<MedicalSpecialty> MedicalSpecialties { get; set; }
        DbSet<NotificationRecord> NotificationRecords { get; set; }
        DbSet<NotificationRule> NotificationRules { get; set; }
        DbSet<NotificationTemplate> NotificationTemplates { get; set; }
        DbSet<Office> Offices { get; set; }
        DbSet<PatientAdditionalInformation> PatientAdditionalInformations { get; set; }
        DbSet<PatientFile> PatientFiles { get; set; }
        DbSet<PatientHospitalizationInformation> PatientHospitalizationInformations { get; set; }
        DbSet<PatientInfoTag> PatientInfoTags { get; set; }
        DbSet<PatientMedicationInformation> PatientMedicationInformations { get; set; }
        DbSet<PatientNotificationMessage> PatientNotificationMessages { get; set; }
        DbSet<PatientRecord> PatientRecords { get; set; }
        DbSet<Patient> Patients { get; set; }
        DbSet<RoleGroup> RoleGroups { get; set; }
        DbSet<RoleGroupUser> RoleGroupUsers { get; set; }
        DbSet<Specialty> Specialties { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<UserTokenSession> UserTokenSessions { get; set; }
        DbSet<ScheduleCalendar> ScheduleCalendars { get; set; }
    }
}
