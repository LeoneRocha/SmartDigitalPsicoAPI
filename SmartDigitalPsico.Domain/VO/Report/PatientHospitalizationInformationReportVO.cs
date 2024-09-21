using SmartDigitalPsico.Domain.Helpers;
using System.ComponentModel;

namespace SmartDigitalPsico.Domain.VO.Report
{
    public class PatientHospitalizationInformationReportVO
    {
        #region Columns 
         
        public string Description { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string CID { get; set; } = string.Empty;

        public string Observation { get; set; } = string.Empty;

        #endregion Columns 
    }
}
