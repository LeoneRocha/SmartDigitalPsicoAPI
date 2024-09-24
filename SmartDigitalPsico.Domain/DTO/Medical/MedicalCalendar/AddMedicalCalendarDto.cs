using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar
{
    public class AddMedicalCalendarDto : EntityDtoBaseAdd
    {
        #region Relationship 
        public long MedicalId { get; set; }
        #endregion Relationship

        #region Columns 
        public string Title { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool AllDay { get; set; }
        public EStatusCalendar Status { get; set; }
        public string ColorCategory { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public bool PushedCalendar { get; set; }
        public string TimeZone { get; set; } = string.Empty;
        #endregion Columns 
    }
}