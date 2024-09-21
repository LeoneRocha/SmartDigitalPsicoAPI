using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using System.Text.Json.Serialization;

namespace SmartDigitalPsico.Domain.VO.Report.Patient
{
    public class PatientDetailReportVO
    {
        public GenderReportVO Gender { get; set; } = new GenderReportVO();

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }


        public string Profession { get; set; } = string.Empty;


        public string Cpf { get; set; } = string.Empty;


        public string Rg { get; set; } = string.Empty;


        public string Education { get; set; } = string.Empty;


        public string PhoneNumber { get; set; } = string.Empty;


        public string AddressStreet { get; set; } = string.Empty;


        public string AddressNeighborhood { get; set; } = string.Empty;


        public string AddressCity { get; set; } = string.Empty;


        public string AddressState { get; set; } = string.Empty;


        public string AddressCep { get; set; } = string.Empty;


        public string EmergencyContactName { get; set; } = string.Empty;

        [JsonConverter(typeof(EnumDescriptionConverter<EMaritalStatus>))]
        public EMaritalStatus MaritalStatus { get; set; }

        public string EmergencyContactPhoneNumber { get; set; } = string.Empty;

        public PatientAdditionalInformationReportVO[] PatientAdditionalInformations { get; set; } = [];
        public PatientHospitalizationInformationReportVO[] PatientHospitalizationInformations { get; set; } = [];
        public PatientMedicationInformationReportVO[] PatientMedicationInformations { get; set; } = [];
        public PatientRecordReportVO[] PatientRecords { get; set; } = [];
    }
}
