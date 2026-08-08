using System.ComponentModel;

namespace SmartDigitalPsico.Domain.DTO.Report.Enitty
{
    /// <summary>
    /// Classe responsável por PatientRecordReportDto.
    /// Responsabilidade: geração de relatórios.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class PatientRecordReportDto
    {
        #region Columns 
        public string Description { get; set; } = string.Empty;
        public string Annotation { get; set; } = string.Empty;
        [Description("Date")]
        public DateTime AnnotationDate { get; set; }
        #endregion Columns 
    }
}
