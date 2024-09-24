using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.DTO.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.DTO.Medical
{
    public class AddMedicalDto : EntityDtoBaseAdd
    {
        #region Relationship   
        public long OfficeId { get; set; }     
        public List<long> SpecialtiesIds { get; set; } = new List<long>();

        #endregion Relationship

        #region Columns 
        public string Name { get; set; } = string.Empty;         
        public string Email { get; set; } = string.Empty;         
        public string Accreditation { get; set; } = string.Empty;
        public ETypeAccreditation TypeAccreditation { get; set; }

        #endregion Columns  
    }
}