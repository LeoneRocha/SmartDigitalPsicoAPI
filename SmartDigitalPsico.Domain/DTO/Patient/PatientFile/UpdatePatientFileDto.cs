using System.ComponentModel.DataAnnotations;
using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientFile
{
    public class UpdatePatientFileDto : EntityDtoBase
    {
        [MaxLength(255)]
        public string Description { get; set; } = string.Empty; 

        [MaxLength(2083)]
        [Required]
        public string FilePath { get; set; } = string.Empty;
    }
}