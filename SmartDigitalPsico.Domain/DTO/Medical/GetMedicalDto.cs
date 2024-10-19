using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.DTO.Contracts;
using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Patient;

namespace SmartDigitalPsico.Domain.DTO.Medical
{
    public class GetMedicalDto : EntityDtoBase, ISupportsHyperMedia
    { 
        public string Name { get; set; } = string.Empty;

        #region Relationship
        public GetOfficeDto Office { get; set; } = new GetOfficeDto();
        public List<GetSpecialtyDto> Specialties { get; set; } = new List<GetSpecialtyDto>();
        public List<GetPatientDto> Patients { get; set; } = new List<GetPatientDto>();
        #endregion Relationship

        #region Columns

        public string Email { get; set; } = string.Empty;
        public string Accreditation { get; set; } = string.Empty;
        public ETypeAccreditation TypeAccreditation { get; set; }
        public DayOfWeek[] WorkingDays { get; set; } = [];
        #endregion Columns  

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>(); 
    }
}