using System.ComponentModel;

namespace SmartDigitalPsico.Domain.VO.Report
{
    public class PatientMedicationInformationReportVO
    {
        #region Columns 

        public string Description { get; set; } = string.Empty;

        [Description("Start Date")]
        public DateTime StartDate { get; set; }

        [Description("End Date")]
        public DateTime? EndDate { get; set; }

        public string Dosage { get; set; } = string.Empty;

        public string Posology { get; set; } = string.Empty;

        [Description("Main Drug")]
        public string MainDrug { get; set; } = string.Empty;

        #endregion Columns 
    }
}
