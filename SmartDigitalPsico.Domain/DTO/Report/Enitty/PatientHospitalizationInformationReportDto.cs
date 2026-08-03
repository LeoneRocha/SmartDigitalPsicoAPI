using SmartDigitalPsico.Domain.Helpers;
using System.ComponentModel;

namespace SmartDigitalPsico.Domain.DTO.Report.Enitty
{
    /// <summary>
    /// Classe responsável por PatientHospitalizationInformationReportDto.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
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
