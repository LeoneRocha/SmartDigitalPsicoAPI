namespace SmartDigitalPsico.Domain.VO.Report
{
    public class PatientMedicationInformationReportVO
    {
        #region Columns 

        public string Description { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Dosage { get; set; } = string.Empty;

        public string Posology { get; set; } = string.Empty;

        public string MainDrug { get; set; } = string.Empty;

        #endregion Columns 
    }
}
