using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Helpers;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace SmartDigitalPsico.Domain.VO.Report.Patient
{
    public class PatientDetailReportVO
    {
        [JsonIgnore]
        public GenderReportVO Gender { get; set; } = new GenderReportVO();

        [Order(2)]
        [Description("Gender")]
        public string GenderDesc { get { return Gender.Description; } }

        [Order(0)]
        public string Name { get; set; } = string.Empty;

        [Order(1)]
        public string Email { get; set; } = string.Empty;

        [Order(3)]
        public DateTime DateOfBirth { get; set; }
         
        [Order(4)]
        public string Profession { get; set; } = string.Empty;

        [Order(5)]
        public string Cpf { get; set; } = string.Empty;


        [Order(6)]
        public string Rg { get; set; } = string.Empty;

        [Order(7)]
        public string Education { get; set; } = string.Empty;

        [Order(8)]
        [Description("Number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Order(9)]
        [Description("Street")]
        public string AddressStreet { get; set; } = string.Empty;

        [Order(10)]
        [Description("Neighborhood")]
        public string AddressNeighborhood { get; set; } = string.Empty;

        [Order(11)]
        [Description("City")]
        public string AddressCity { get; set; } = string.Empty;

        [Order(12)]
        [Description("State")]
        public string AddressState { get; set; } = string.Empty;

        [Order(13)]
        [Description("CEP")]
        public string AddressCep { get; set; } = string.Empty;

        [Order(14)]
        [Description("Emergency Contact Name")]
        public string EmergencyContactName { get; set; } = string.Empty;

        [Order(15)]
        [JsonConverter(typeof(EnumDescriptionConverter<EMaritalStatus>))]
        [Description("Marital Status")]
        public EMaritalStatus MaritalStatus { get; set; }

        [Order(16)]
        [Description("Emergency Contact Phone Number")] 
        public string EmergencyContactPhoneNumber { get; set; } = string.Empty;

        public PatientAdditionalInformationReportVO[] PatientAdditionalInformations { get; set; } = [];
        public PatientHospitalizationInformationReportVO[] PatientHospitalizationInformations { get; set; } = [];
        public PatientMedicationInformationReportVO[] PatientMedicationInformations { get; set; } = [];
        public PatientRecordReportVO[] PatientRecords { get; set; } = [];
    }
}
