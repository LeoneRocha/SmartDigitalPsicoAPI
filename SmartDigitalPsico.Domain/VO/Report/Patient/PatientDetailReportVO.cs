using SmartDigitalPsico.Domain.VO.Patient;
using SmartDigitalPsico.Domain.VO.Patient.PatientAdditionalInformation;
using SmartDigitalPsico.Domain.VO.Patient.PatientHospitalizationInformation;
using SmartDigitalPsico.Domain.VO.Patient.PatientMedicationInformation;
using SmartDigitalPsico.Domain.VO.Patient.PatientRecord;

namespace SmartDigitalPsico.Domain.VO.Report.Patient
{
    public class PatientDetailReportVO : GetPatientVO
    {    
        public ICollection<GetPatientAdditionalInformationVO> PatientAdditionalInformations { get; set; } = new List<GetPatientAdditionalInformationVO>();  
        public ICollection<GetPatientHospitalizationInformationVO> PatientHospitalizationInformations { get; set; } = new List<GetPatientHospitalizationInformationVO>();   
        public ICollection<GetPatientMedicationInformationVO> PatientMedicationInformations { get; set; } = new List<GetPatientMedicationInformationVO>();
        public ICollection<GetPatientRecordVO> PatientRecords { get; set; } = new List<GetPatientRecordVO>();    
    }
}
