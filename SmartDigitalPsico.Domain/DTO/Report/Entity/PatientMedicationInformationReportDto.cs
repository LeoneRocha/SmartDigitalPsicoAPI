using System.ComponentModel;

namespace SmartDigitalPsico.Domain.DTO.Report.Entity
{
    /// <summary>
    /// Classe responsável por PatientMedicationInformationReportDto.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class PatientMedicationInformationReportDto
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
