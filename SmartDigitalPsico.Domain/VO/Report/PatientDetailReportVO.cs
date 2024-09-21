using SmartDigitalPsico.Domain.Enuns;

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

        public EMaritalStatus MaritalStatus { get; set; }

        public string EmergencyContactPhoneNumber { get; set; } = string.Empty;

        public ICollection<PatientAdditionalInformationReportVO> PatientAdditionalInformations { get; set; } = new List<PatientAdditionalInformationReportVO>();
        public ICollection<PatientHospitalizationInformationReportVO> PatientHospitalizationInformations { get; set; } = new List<PatientHospitalizationInformationReportVO>();
        public ICollection<PatientMedicationInformationReportVO> PatientMedicationInformations { get; set; } = new List<PatientMedicationInformationReportVO>();
        public ICollection<PatientRecordReportVO> PatientRecords { get; set; } = new List<PatientRecordReportVO>();
    }
}
