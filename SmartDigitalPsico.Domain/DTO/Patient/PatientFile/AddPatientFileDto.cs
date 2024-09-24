using Microsoft.AspNetCore.Http;
using SmartDigitalPsico.Domain.DTO.Medical.MedicalFile;
using SmartDigitalPsico.Domain.Interfaces;

namespace SmartDigitalPsico.Domain.DTO.Patient.PatientFile
{
    public class AddPatientFileDto : FileBaseDto, IEntityDtoAdd
    {
        public long PatientId { get; set; }
        public IFormFile FileDetails { get; set; } = new FormFile(Stream.Null, 0, 0, string.Empty, string.Empty);
    }
}