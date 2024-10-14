using AutoMapper;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.DTO.Contracts;
using SmartDigitalPsico.Domain.DTO.Domains.AddDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Domains.UpdateDTOs;
using SmartDigitalPsico.Domain.DTO.Medical;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile;
using SmartDigitalPsico.Domain.DTO.Patient;
using SmartDigitalPsico.Domain.DTO.Patient.PatientAdditionalInformation;
using SmartDigitalPsico.Domain.DTO.Patient.PatientFile;
using SmartDigitalPsico.Domain.DTO.Patient.PatientHospitalizationInformation;
using SmartDigitalPsico.Domain.DTO.Patient.PatientMedicationInformation;
using SmartDigitalPsico.Domain.DTO.Patient.PatientNotificationMessage;
using SmartDigitalPsico.Domain.DTO.Patient.PatientRecord;
using SmartDigitalPsico.Domain.DTO.Report.Enitty;
using SmartDigitalPsico.Domain.DTO.User;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.TableEntityNoSQL;

namespace SmartDigitalPsico.Domain.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region EntityBase
            CreateMap<EntityBaseWithNameEmail, EntityDtoBaseName>();
            CreateMap<EntityDtoBaseName, EntityBaseWithNameEmail>();

            CreateMap<EntityBase, EntityDtoBaseDomain>();
            CreateMap<EntityDtoBaseDomain, EntityBase>();
            #endregion

            #region ApplicationConfigSetting
            CreateMap<ApplicationConfigSetting, GetApplicationConfigSettingDto>();
            CreateMap<GetApplicationConfigSettingDto, ApplicationConfigSetting>();

            CreateMap<AddApplicationConfigSettingDto, ApplicationConfigSetting>();
            CreateMap<UpdateApplicationConfigSettingDto, ApplicationConfigSetting>();
            #endregion  ApplicationConfigSetting

            #region ApplicationLanguage
            CreateMap<ApplicationLanguage, GetApplicationLanguageDto>();
            CreateMap<GetApplicationLanguageDto, ApplicationLanguage>();

            CreateMap<AddApplicationLanguageDto, ApplicationLanguage>();
            CreateMap<UpdateApplicationLanguageDto, ApplicationLanguage>();
            #endregion  ApplicationLanguage

            #region PatientFile
            CreateMap<AddPatientFileDtoservice, AddPatientFileDto>();

            CreateMap<PatientFile, GetPatientFileDto>();
            CreateMap<GetPatientFileDto, PatientFile>();

            CreateMap<AddPatientFileDto, PatientFile>();
            CreateMap<UpdatePatientFileDto, PatientFile>();
            #endregion  PatientFile

            #region MedicalFile
            CreateMap<AddMedicalFileDtoService, AddMedicalFileDto>();

            CreateMap<MedicalFile, GetMedicalFileDto>();
            CreateMap<GetPatientFileDto, MedicalFile>();

            CreateMap<AddMedicalFileDto, MedicalFile>();
            CreateMap<UpdateMedicalFileDto, MedicalFile>();
            #endregion  MedicalFile

            #region MedicalCalendar
            CreateMap<MedicalCalendar, AddMedicalCalendarDto>();
            CreateMap<AddMedicalCalendarDto, MedicalCalendar>();

            CreateMap<MedicalCalendar, UpdateMedicalCalendarDto>();
            CreateMap<UpdateMedicalCalendarDto, MedicalCalendar>();

            CreateMap<MedicalCalendar, GetMedicalCalendarDto>();
            CreateMap<GetMedicalCalendarDto, MedicalCalendar>();

            CreateMap<MedicalCalendar, GetMedicalCalendarTimeSlotDto>();
            #endregion  MedicalCalendar

            #region Gender
            CreateMap<Gender, GetGenderDto>();
            CreateMap<GetGenderDto, Gender>();

            CreateMap<AddGenderDto, Gender>();
            CreateMap<UpdateGenderDto, Gender>();
            #endregion  Gender

            #region Office
            CreateMap<Office, GetOfficeDto>();
            CreateMap<GetOfficeDto, Office>();

            CreateMap<AddOfficeDto, Office>();
            CreateMap<UpdateOfficeDto, Office>();
            #endregion Office

            #region RoleGroup
            CreateMap<RoleGroup, GetRoleGroupDto>();
            CreateMap<GetRoleGroupDto, RoleGroup>();

            CreateMap<AddRoleGroupDto, RoleGroup>();
            CreateMap<UpdateRoleGroupDto, RoleGroup>();
            #endregion RoleGroup

            #region Specialty
            CreateMap<Specialty, GetSpecialtyDto>();
            CreateMap<GetSpecialtyDto, Specialty>();

            CreateMap<AddSpecialtyDto, Specialty>();
            CreateMap<UpdateSpecialtyDto, Specialty>();
            #endregion Specialty

            #region USER
            CreateMap<User, GetUserDto>();
            CreateMap<User, GetUserAuthenticatedDto>();
            CreateMap<GetUserDto, User>();
            CreateMap<UpdateUserDto, User>();
            CreateMap<UserLoginDto, User>();
            CreateMap<UserRegisterDto, User>();
            #endregion USER

            #region Medical
            CreateMap<Medical, GetMedicalDto>();
            CreateMap<GetMedicalDto, Medical>();
            CreateMap<AddMedicalDto, Medical>();
            CreateMap<UpdateMedicalDto, Medical>();
            #endregion Medical 

            #region Patient
            CreateMap<Patient, GetPatientDto>();
            CreateMap<GetPatientDto, Patient>();
            CreateMap<AddPatientDto, Patient>();
            CreateMap<UpdatePatientDto, Patient>();
            #endregion Patient 

            #region PatientRecord
            CreateMap<PatientRecord, GetPatientRecordDto>();
            CreateMap<GetPatientRecordDto, PatientRecord>();
            CreateMap<AddPatientRecordDto, PatientRecord>();
            CreateMap<UpdatePatientRecordDto, PatientRecord>();
            #endregion PatientRecord 

            #region PatientAdditionalInformation
            CreateMap<PatientAdditionalInformation, GetPatientAdditionalInformationDto>();
            CreateMap<GetPatientAdditionalInformationDto, PatientAdditionalInformation>();
            CreateMap<AddPatientAdditionalInformationDto, PatientAdditionalInformation>();
            CreateMap<UpdatePatientAdditionalInformationDto, PatientAdditionalInformation>();
            #endregion PatientAdditionalInformation 

            #region PatientHospitalizationInformation
            CreateMap<PatientHospitalizationInformation, GetPatientHospitalizationInformationDto>();
            CreateMap<GetPatientHospitalizationInformationDto, PatientHospitalizationInformation>();
            CreateMap<AddPatientHospitalizationInformationDto, PatientHospitalizationInformation>();
            CreateMap<UpdatePatientHospitalizationInformationDto, PatientHospitalizationInformation>();
            #endregion PatientHospitalizationInformation 

            #region PatientMedicationInformation
            CreateMap<PatientMedicationInformation, GetPatientMedicationInformationDto>();
            CreateMap<GetPatientMedicationInformationDto, PatientMedicationInformation>();
            CreateMap<AddPatientMedicationInformationDto, PatientMedicationInformation>();
            CreateMap<UpdatePatientMedicationInformationDto, PatientMedicationInformation>();
            #endregion PatientMedicationInformation 

            #region PatientNotificationMessage
            CreateMap<PatientNotificationMessage, GetPatientNotificationMessageVO>();
            CreateMap<GetPatientNotificationMessageVO, PatientNotificationMessage>();
            CreateMap<AddPatientNotificationMessageDto, PatientNotificationMessage>();
            CreateMap<UpdatePatientNotificationMessageDto, PatientNotificationMessage>();
            #endregion PatientNotificationMessage 

            #region REPORT 
            CreateMap<Patient, PatientDetailReportDto>();
            CreateMap<PatientDetailReportDto, Patient>();
            //Gender
            CreateMap<Gender, GenderReportDto>();
            CreateMap<GenderReportDto, Gender>();
            //PatientAdditionalInformation
            CreateMap<PatientAdditionalInformation, PatientAdditionalInformationReportDto>();
            CreateMap<PatientAdditionalInformationReportDto, PatientAdditionalInformation>();
            //PatientHospitalizationInformation
            CreateMap<PatientHospitalizationInformation, PatientHospitalizationInformationReportDto>();
            CreateMap<PatientHospitalizationInformationReportDto, PatientHospitalizationInformation>();
            //PatientMedicationInformation
            CreateMap<PatientMedicationInformation, PatientMedicationInformationReportDto>();
            CreateMap<PatientMedicationInformationReportDto, PatientMedicationInformation>();
            //PatientRecord
            CreateMap<PatientRecord, PatientRecordReportDto>();
            CreateMap<PatientRecordReportDto, PatientRecord>();
            #endregion REPORT

            #region Audit  
            //AuditDataSelectiveEntityLog
            CreateMap<AuditDataSelectiveEntityLog, GetAuditDataSelectiveEntityLogDto>();
            CreateMap<GetAuditDataSelectiveEntityLogDto, AuditDataSelectiveEntityLog>();
            CreateMap<AddAuditDataSelectiveEntityLogDto, AuditDataSelectiveEntityLog>();
            CreateMap<UpdateAuditDataSelectiveEntityLogDto, AuditDataSelectiveEntityLog>();
            #endregion Audit  

            #region EmailTemplate
            CreateMap<EmailTemplate, GetEmailTemplateDto>();
            CreateMap<GetEmailTemplateDto, EmailTemplate>();

            CreateMap<AddEmailTemplateDto, EmailTemplate>();
            CreateMap<UpdateEmailTemplateDto, EmailTemplate>();
            #endregion EmailTemplate 

            CreateMap<UserTokenSession, UserTokenSessionTableEntity>();
            CreateMap<UserTokenSessionTableEntity, UserTokenSession>();
        }
    }
}