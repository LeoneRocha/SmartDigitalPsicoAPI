using AutoMapper;
using SmartDigitalPsico.Domain.Contracts;
using SmartDigitalPsico.Domain.ModelEntity;
using SmartDigitalPsico.Domain.VO.Contracts;
using SmartDigitalPsico.Domain.VO.Domains.AddVOs;
using SmartDigitalPsico.Domain.VO.Domains.GetVOs;
using SmartDigitalPsico.Domain.VO.Domains.UpdateVOs;
using SmartDigitalPsico.Domain.VO.Medical;
using SmartDigitalPsico.Domain.VO.Medical.MedicalFile;
using SmartDigitalPsico.Domain.VO.Patient;
using SmartDigitalPsico.Domain.VO.Patient.PatientAdditionalInformation;
using SmartDigitalPsico.Domain.VO.Patient.PatientFile;
using SmartDigitalPsico.Domain.VO.Patient.PatientHospitalizationInformation;
using SmartDigitalPsico.Domain.VO.Patient.PatientMedicationInformation;
using SmartDigitalPsico.Domain.VO.Patient.PatientNotificationMessage;
using SmartDigitalPsico.Domain.VO.Patient.PatientRecord;
using SmartDigitalPsico.Domain.VO.Report.Patient;
using SmartDigitalPsico.Domain.VO.User;

namespace SmartDigitalPsico.Domain.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region EntityBase

            CreateMap<EntityBaseWithNameEmail, EntityVOBaseName>();
            CreateMap<EntityVOBaseName, EntityBaseWithNameEmail>();

            CreateMap<EntityBase, EntityVOBaseDomain>();
            CreateMap<EntityVOBaseDomain, EntityBase>();

            #endregion

            #region ApplicationConfigSetting
            CreateMap<ApplicationConfigSetting, GetApplicationConfigSettingVO>();
            CreateMap<GetApplicationConfigSettingVO, ApplicationConfigSetting>();

            CreateMap<AddApplicationConfigSettingVO, ApplicationConfigSetting>();
            CreateMap<UpdateApplicationConfigSettingVO, ApplicationConfigSetting>();

            #endregion  ApplicationConfigSetting

            #region ApplicationLanguage

            CreateMap<ApplicationLanguage, GetApplicationLanguageVO>();
            CreateMap<GetApplicationLanguageVO, ApplicationLanguage>();

            CreateMap<AddApplicationLanguageVO, ApplicationLanguage>();
            CreateMap<UpdateApplicationLanguageVO, ApplicationLanguage>();

            #endregion  ApplicationLanguage

            #region PatientFile
            CreateMap<AddPatientFileVOService, AddPatientFileVO>();

            CreateMap<PatientFile, GetPatientFileVO>();
            CreateMap<GetPatientFileVO, PatientFile>();

            CreateMap<AddPatientFileVO, PatientFile>();
            CreateMap<UpdatePatientFileVO, PatientFile>();

            #endregion  PatientFile

            #region MedicalFile
            CreateMap<AddMedicalFileVOService, AddMedicalFileVO>();


            CreateMap<MedicalFile, GetMedicalFileVO>();
            CreateMap<GetPatientFileVO, MedicalFile>();

            CreateMap<AddMedicalFileVO, MedicalFile>();
            CreateMap<UpdateMedicalFileVO, MedicalFile>();

            #endregion  MedicalFile

            #region Gender
            CreateMap<Gender, GetGenderVO>();
            CreateMap<GetGenderVO, Gender>();

            CreateMap<AddGenderVO, Gender>();
            CreateMap<UpdateGenderVO, Gender>();

            #endregion  Gender

            #region Office
            CreateMap<Office, GetOfficeVO>();
            CreateMap<GetOfficeVO, Office>();


            CreateMap<AddOfficeVO, Office>();
            CreateMap<UpdateOfficeVO, Office>();

            #endregion Office

            #region RoleGroup
            CreateMap<RoleGroup, GetRoleGroupVO>();
            CreateMap<GetRoleGroupVO, RoleGroup>();

            CreateMap<AddRoleGroupVO, RoleGroup>();
            CreateMap<UpdateRoleGroupVO, RoleGroup>();


            #endregion RoleGroup

            #region Specialty
            CreateMap<Specialty, GetSpecialtyVO>();
            CreateMap<GetSpecialtyVO, Specialty>();

            CreateMap<AddSpecialtyVO, Specialty>();
            CreateMap<UpdateSpecialtyVO, Specialty>();
            #endregion Specialty

            #region USER
            CreateMap<User, GetUserVO>();
            CreateMap<User, GetUserAuthenticatedVO>();
            CreateMap<GetUserVO, User>();
            CreateMap<UpdateUserVO, User>();
            CreateMap<UserLoginVO, User>();
            CreateMap<UserRegisterVO, User>();
            #endregion USER

            #region Medical
            CreateMap<Medical, GetMedicalVO>();
            CreateMap<GetMedicalVO, Medical>();
            CreateMap<AddMedicalVO, Medical>();
            CreateMap<UpdateMedicalVO, Medical>();

            #endregion Medical 

            #region Patient
            CreateMap<Patient, GetPatientVO>();
            CreateMap<GetPatientVO, Patient>();
            CreateMap<AddPatientVO, Patient>();
            CreateMap<UpdatePatientVO, Patient>();
             
            CreateMap<Patient, PatientDetailReportVO>(); 
            CreateMap<PatientDetailReportVO, Patient>();
            #endregion Patient 

            #region PatientRecord
            CreateMap<PatientRecord, GetPatientRecordVO>();
            CreateMap<GetPatientRecordVO, PatientRecord>();
            CreateMap<AddPatientRecordVO, PatientRecord>();
            CreateMap<UpdatePatientRecordVO, PatientRecord>();

            #endregion PatientRecord 

            #region PatientAdditionalInformation
            CreateMap<PatientAdditionalInformation, GetPatientAdditionalInformationVO>();
            CreateMap<GetPatientAdditionalInformationVO, PatientAdditionalInformation>();
            CreateMap<AddPatientAdditionalInformationVO, PatientAdditionalInformation>();
            CreateMap<UpdatePatientAdditionalInformationVO, PatientAdditionalInformation>();

            #endregion PatientAdditionalInformation 

            #region PatientHospitalizationInformation
            CreateMap<PatientHospitalizationInformation, GetPatientHospitalizationInformationVO>();
            CreateMap<GetPatientHospitalizationInformationVO, PatientHospitalizationInformation>();
            CreateMap<AddPatientHospitalizationInformationVO, PatientHospitalizationInformation>();
            CreateMap<UpdatePatientHospitalizationInformationVO, PatientHospitalizationInformation>();

            #endregion PatientHospitalizationInformation 

            #region PatientMedicationInformation
            CreateMap<PatientMedicationInformation, GetPatientMedicationInformationVO>();
            CreateMap<GetPatientMedicationInformationVO, PatientMedicationInformation>();
            CreateMap<AddPatientMedicationInformationVO, PatientMedicationInformation>();
            CreateMap<UpdatePatientMedicationInformationVO, PatientMedicationInformation>();

            #endregion PatientMedicationInformation 

            #region PatientNotificationMessage
            CreateMap<PatientNotificationMessage, GetPatientNotificationMessageVO>();
            CreateMap<GetPatientNotificationMessageVO, PatientNotificationMessage>();
            CreateMap<AddPatientNotificationMessageVO, PatientNotificationMessage>();
            CreateMap<UpdatePatientNotificationMessageVO, PatientNotificationMessage>();

            #endregion PatientNotificationMessage 
        }
    }
}