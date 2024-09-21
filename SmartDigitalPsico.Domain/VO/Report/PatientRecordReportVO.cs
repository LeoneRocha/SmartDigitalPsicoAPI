using SmartDigitalPsico.Domain.Helpers;
using System.ComponentModel;

namespace SmartDigitalPsico.Domain.VO.Report
{
    public class PatientRecordReportVO
    {
        #region Columns 

        public string Description { get; set; } = string.Empty;

        public string Annotation { get; set; } = string.Empty;
         
        [Description("Date")]
        public DateTime AnnotationDate { get; set; }

        #endregion Columns 
    }
}
