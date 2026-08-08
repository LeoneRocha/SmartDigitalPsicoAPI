using SmartDigitalPsico.Domain.Enuns;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace SmartDigitalPsico.Domain.DTO.Report.Enitty
{
    /// <summary>
    /// Classe responsável por PatientDetailReportDto.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class PatientDetailReportDto
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public GenderReportDto Gender { get; set; } = new GenderReportDto();

        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(2)]
        [Description("Gender")]
        public string GenderDesc { get { return Gender.Description; } }

        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(0)]
        public string Name { get; set; } = string.Empty;

        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(1)]
        public string Email { get; set; } = string.Empty;

        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(3)]
        [Description("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(4)]
        public string Profession { get; set; } = string.Empty;

        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(5)]
        public string Cpf { get; set; } = string.Empty;


        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(6)]
        public string Rg { get; set; } = string.Empty;

        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(7)]
        public string Education { get; set; } = string.Empty;

        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(8)]
        [Description("Number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(9)]
        [Description("Street")]
        public string AddressStreet { get; set; } = string.Empty;

        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(10)]
        [Description("Neighborhood")]
        public string AddressNeighborhood { get; set; } = string.Empty;

        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(11)]
        [Description("City")]
        public string AddressCity { get; set; } = string.Empty;

        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(12)]
        [Description("State")]
        public string AddressState { get; set; } = string.Empty;

        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(13)]
        [Description("CEP")]
        public string AddressCep { get; set; } = string.Empty;

        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(14)]
        [Description("Emergency Contact Name")]
        public string EmergencyContactName { get; set; } = string.Empty;

        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(15)]
        [JsonConverter(typeof(SmartDigitalPsico.Core.SDK.Domain.Helpers.EnumDescriptionConverter<EMaritalStatus>))]
        [Description("Marital Status")]
        public EMaritalStatus MaritalStatus { get; set; }

        [SmartDigitalPsico.Core.SDK.Domain.Helpers.Order(16)]
        [Description("Emergency Contact Phone Number")]
        public string EmergencyContactPhoneNumber { get; set; } = string.Empty;

        public PatientAdditionalInformationReportDto[] PatientAdditionalInformations { get; set; } = [];
        public PatientHospitalizationInformationReportDto[] PatientHospitalizationInformations { get; set; } = [];
        public PatientMedicationInformationReportDto[] PatientMedicationInformations { get; set; } = [];
        public PatientRecordReportDto[] PatientRecords { get; set; } = [];
    }
}
