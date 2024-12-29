using SmartDigitalPsico.Domain.DTO.Domains.GetDTOs;
using SmartDigitalPsico.Domain.DTO.Patient;
using SmartDigitalPsico.Domain.Hypermedia;
using SmartDigitalPsico.Domain.Hypermedia.Abstract;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Medical
{
    public class GetMedicalDto : ActionMedicalDtoBase, IEntityDto, ISupportsHyperMedia
    {   
        #region Relationship
        public GetOfficeDto Office { get; set; } = new GetOfficeDto();
        public List<GetSpecialtyDto> Specialties { get; set; } = new List<GetSpecialtyDto>();
        public List<GetPatientDto> Patients { get; set; } = new List<GetPatientDto>();
        #endregion Relationship 
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>(); 
    }
}