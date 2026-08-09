using AutoMapper;
using SmartDigitalPsico.Domain.DTO.Patient.ADD;
using SmartDigitalPsico.Domain.DTO.Patient.Common;
using SmartDigitalPsico.Domain.DTO.Patient.GET;
using SmartDigitalPsico.Domain.DTO.Patient.UPDATE;
using SmartDigitalPsico.Domain.DTO.Report.Entity;
using SmartDigitalPsico.Domain.EntityModels;

namespace SmartDigitalPsico.Domain.Mapper
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            #region Patient
            CreateMap<Patient, GetPatientDto>();
            CreateMap<GetPatientDto, Patient>();
            CreateMap<AddPatientDto, Patient>();
            CreateMap<UpdatePatientDto, Patient>();
            #endregion Patient

            #region PatientFile
            CreateMap<AddPatientFileDtoservice, AddPatientFileDto>();

            CreateMap<PatientFile, GetPatientFileDto>();
            CreateMap<GetPatientFileDto, PatientFile>();

            CreateMap<AddPatientFileDto, PatientFile>();
            CreateMap<UpdatePatientFileDto, PatientFile>();
            #endregion PatientFile

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

            #region Patient Report
            CreateMap<Patient, PatientDetailReportDto>();
            CreateMap<PatientDetailReportDto, Patient>();

            CreateMap<PatientAdditionalInformation, PatientAdditionalInformationReportDto>();
            CreateMap<PatientAdditionalInformationReportDto, PatientAdditionalInformation>();

            CreateMap<PatientHospitalizationInformation, PatientHospitalizationInformationReportDto>();
            CreateMap<PatientHospitalizationInformationReportDto, PatientHospitalizationInformation>();

            CreateMap<PatientMedicationInformation, PatientMedicationInformationReportDto>();
            CreateMap<PatientMedicationInformationReportDto, PatientMedicationInformation>();

            CreateMap<PatientRecord, PatientRecordReportDto>();
            CreateMap<PatientRecordReportDto, PatientRecord>();
            #endregion Patient Report
        }
    }
}
