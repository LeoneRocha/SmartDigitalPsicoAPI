using SmartDigitalPsico.Domain.Helpers;
using System.ComponentModel;

namespace SmartDigitalPsico.Domain.VO.Report
{
    public class PatientAdditionalInformationReportVO
    {
        [Order(0)]
        [Description("Psychiatric")]
        public string FollowUp_Psychiatric { get; set; } = string.Empty;

        [Order(1)]
        [Description("Neurological")]
        public string FollowUp_Neurological { get; set; } = string.Empty;
    }
}
