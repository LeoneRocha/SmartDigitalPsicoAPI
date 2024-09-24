using SmartDigitalPsico.Domain.DTO.Contracts;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientFile
{
    public class UpdatePatientFileDto : EntityDtoBase
    { 
        public string Description { get; set; } = string.Empty;          
        public string FilePath { get; set; } = string.Empty;
    }
}