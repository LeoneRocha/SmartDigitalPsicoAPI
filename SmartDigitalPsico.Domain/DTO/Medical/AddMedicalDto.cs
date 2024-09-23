using SmartDigitalPsico.Domain.Enuns;
using SmartDigitalPsico.Domain.DTO.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SmartDigitalPsico.Domain.DTO.Medical
{
    public class AddMedicalDto : EntityDtoBaseAdd
    {
        #region Relationship
        [Required]
        public long OfficeId { get; set; }
        [MaxLength(20)]

        [Required]
        public List<long> SpecialtiesIds { get; set; } = new List<long>();

        #endregion Relationship

        #region Columns
        [MaxLength(255)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [MaxLength(100)]
        [Required]
        public string Email { get; set; } = string.Empty;

        [MaxLength(20)]
        [Required]
        public string Accreditation { get; set; } = string.Empty;

        public ETypeAccreditation TypeAccreditation { get; set; }

        #endregion Columns  
    }
}