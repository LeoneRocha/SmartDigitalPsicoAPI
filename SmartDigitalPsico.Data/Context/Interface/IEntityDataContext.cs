﻿using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Domain.ModelEntity;

namespace SmartDigitalPsico.Data.Context.Interface
{
    public interface IEntityDataContext
    {
        DbSet<ApplicationCacheLog> ApplicationCacheLogs { get; set; }
        DbSet<ApplicationConfigSetting> ApplicationConfigSettings { get; set; }
        DbSet<ApplicationLanguage> ApplicationLanguages { get; set; }
        DbSet<AuditDataEntityLog> AuditLogs { get; set; }
        DbSet<AuditDataSelectiveEntityLog> AuditSelectiveLogs { get; set; }
        DbSet<Gender> Genders { get; set; }
        DbSet<InfoTag> InfoTags { get; set; }
        DbSet<MedicalCalendar> MedicalCalendars { get; set; }
        DbSet<MedicalFile> MedicalFiles { get; set; }
        DbSet<Medical> Medicals { get; set; }
        DbSet<MedicalSpecialty> MedicalSpecialties { get; set; }
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
    }
}