using SmartDigitalPsico.Domain.Helpers;
using System.ComponentModel;

namespace SmartDigitalPsico.Domain.DTO.Report.Enitty
{
    public class PatientHospitalizationInformationReportDto
    {
        #region Columns          
        public string Description { get; set; } = string.Empty;

        [Description("Start Date")]
        public DateTime StartDate { get; set; }

        [Description("End Date")]
        public DateTime? EndDate { get; set; }
        public string CID { get; set; } = string.Empty;
        public string Observation { get; set; } = string.Empty;
        #endregion Columns 
    }
}
