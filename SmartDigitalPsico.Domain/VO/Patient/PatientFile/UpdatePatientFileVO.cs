using System.ComponentModel.DataAnnotations;
using SmartDigitalPsico.Domain.VO.Contracts;

namespace SmartDigitalPsico.Domain.VO.Patient.PatientFile
{
    public class UpdatePatientFileVO : EntityVOBase
    {
        [MaxLength(255)]
        public string Description { get; set; } = string.Empty; 

        [MaxLength(2083)]
        [Required]
        public string FilePath { get; set; } = string.Empty;
    }
}