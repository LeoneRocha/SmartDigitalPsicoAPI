using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Contracts;
using SmartDigitalPsico.Domain.DTO.Patient;
using SmartDigitalPsico.Domain.DTO.User;

namespace SmartDigitalPsico.Domain.DTO.Medical.MedicalCalendar
{
    public class GetMedicalCalendarDto : EntityDtoBase, ISupportsHyperMedia
    {
        #region Relationship 
        public GetMedicalDto Medical { get; set; } = new GetMedicalDto();
        public GetPatientDto? Patient { get; set; } = new GetPatientDto();
        public GetUserDto? CreatedUser { get; set; } = new GetUserDto();
        public GetUserDto? ModifyUser { get; set; } = new GetUserDto();
        #endregion Relationship

        #region Columns 

        public string Title { get; set; } = string.Empty;


        public DateTime StartDate { get; set; }


        public DateTime? EndDate { get; set; }

        public bool AllDay { get; set; }

        public int Status { get; set; }

        public string ColorCategory { get; set; } = string.Empty;

        public string Url { get; set; } = string.Empty;

        public bool PushedCalendar { get; set; }

        public string TimeZone { get; set; } = string.Empty;
        #endregion Columns 

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}