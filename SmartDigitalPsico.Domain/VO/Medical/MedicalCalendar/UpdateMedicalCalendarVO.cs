using SmartDigitalPsico.Domain.VO.Contracts;

namespace SmartDigitalPsico.Domain.VO.Medical.MedicalCalendar
{
    public class UpdateMedicalCalendarVO : EntityVOBase
    {
        #region Relationship 

        #endregion Relationship

        #region Columns 

        public string Title { get; set; } = string.Empty;   
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool AllDay { get; set; }
        public string ColorCategory { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public bool PushedCalendar { get; set; }
        public string TimeZone { get; set; } = string.Empty;
        #endregion Columns 
    }
}