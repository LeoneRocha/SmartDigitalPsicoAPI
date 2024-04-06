using SmartDigitalPsico.Domain.VO.Contracts;

namespace SmartDigitalPsico.Domain.VO.Patient.PatientAdditionalInformation
{
    public class UpdatePatientAdditionalInformationVO : EntityVOBase
    {
        public string FollowUp_Psychiatric { get; set; } = string.Empty;

        public string FollowUp_Neurological { get; set; } = string.Empty;

    }
}